using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cob.TradingApps.BtcData;
using Cob.TradingApps.BtcData.Exchanges;
using log4net;
using log4net.Config;
using TradingApi.ModelObjects;
using TradingApi.ModelObjects.Bitfinex.Json;
using TradingApi.ModelObjects.Utility;
using TradingCoins.Controls;

[assembly: XmlConfigurator(Watch = true)]
namespace TradingCoins
{
   public partial class Form1 : Form
   {

      private ConcurrentDictionary<BtcInfo.ExchangeEnum, MarketDataCtrl> _marketDataCtrls;
      private ConcurrentDictionary<BtcInfo.ExchangeEnum, ExchangeAcctCtrl> _tradingAcctCtrls;

      public BitfinexExchange BfExchange
      {
         get { return ExchangeConnectivity.Instance.Exchanges[BtcInfo.ExchangeEnum.BITFINEX] as BitfinexExchange; }
      }

      public Form1()
      {
         BasicConfigurator.Configure();
         InitializeComponent();
         _marketDataCtrls = new ConcurrentDictionary<BtcInfo.ExchangeEnum, MarketDataCtrl>();
         _tradingAcctCtrls = new ConcurrentDictionary<BtcInfo.ExchangeEnum, ExchangeAcctCtrl>();

         var exchanges = Enum.GetValues(typeof(BtcInfo.ExchangeEnum));
         foreach (BtcInfo.ExchangeEnum exchange in exchanges)
         {
            var ctrlMd = new MarketDataCtrl();
            var ctrlAcct = new ExchangeAcctCtrl(this);

            ctrlMd.Tag = exchange;
            ctrlMd.Name = exchange.ToString();

            ctrlAcct.Tag = exchange;
            ctrlAcct.Name = exchange.ToString();

            _marketDataCtrls[exchange] = ctrlMd;
            this.pnlExchange1MarketData.Controls.Add(ctrlMd);
            this.pnlExchange1Trading.Controls.Add(ctrlAcct);

            ctrlMd.Dock = DockStyle.Fill;
            ctrlAcct.Dock = DockStyle.Fill;
         }

         var symbols = Enum.GetValues(typeof(BtcInfo.PairTypeEnum));
         foreach (var symbol in symbols)
         {
            cbPair.Items.Add(symbol);
         }
         cbPair.SelectedItem = BtcInfo.PairTypeEnum.btcusd;

         var callTypes = Enum.GetValues(typeof(BtcInfo.BitfinexUnauthenicatedCallsEnum));
         foreach (var callType in callTypes)
         {
            cbCallTypes.Items.Add(callType);
         }
         cbCallTypes.SelectedItem = BtcInfo.BitfinexUnauthenicatedCallsEnum.pubticker;

         var walletTypes = Enum.GetValues(typeof(BtcInfo.BitfinexWalletEnum));
         foreach (var walletType in walletTypes)
         {
            cbWalletType.Items.Add(walletType);
            cbDepositTo.Items.Add(walletType);
         }

         cbWalletType.SelectedIndex = 0;

         var symbolTypes = Enum.GetValues(typeof(BtcInfo.ExchangeSymbolEnum));
         foreach (var symbolType in symbolTypes)
         {
            cbSymbols.Items.Add(symbolType);
            cbCurrency.Items.Add(symbolType);
         }

         cbSymbols.SelectedIndex = 0;
         cbCurrency.SelectedIndex = 0;

         var offerDirections = Enum.GetValues(typeof(BtcInfo.OfferDirectionEnum));
         foreach (var offerDirection in offerDirections)
         {
            cbDirection.Items.Add(offerDirection);
         }

         cbDirection.SelectedIndex = 0;

      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void btnStart_Click(object sender, EventArgs e)
      {
         ExchangeConnectivity.Instance.Initialize();
         BfExchange.Api.ErrorMessage += ApiOnErrrorMessage;
         BfExchange.Api.OrderFeedMsg += ApiOnOrderFeedMsg;
      }
 
      private void ApiOnOrderFeedMsg(BitfinexNewOrderResponse orderResponse)
      {
         lbLogger.Items.Add(orderResponse.ToString());
      }

      private void ApiOnErrrorMessage(string errorMessage)
      {
         lbLogger.Items.Add(errorMessage);
      }

      private void btnGetOrderStatus_Click(object sender, EventArgs e)
      {
         try
         {
            var x = BfExchange.Api.GetOrderStatus(Convert.ToInt32(txtOrderId.Text));
            lbLogger.Items.Add(x.Id + " is live: " + x.IsLive + ", Price: " + x.Price);

         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }

      private void btnCancelOrder_Click(object sender, EventArgs e)
      {
         try
         {
            var x = BfExchange.Api.CancelOrder(Convert.ToInt32(txtOrderId.Text));
            lbLogger.Items.Add(x.ToString());
         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }

      private void btnCancelAll_Click(object sender, EventArgs e)
      {
         var x = BfExchange.Api.CancellAllActiveOrders();
         lbLogger.Items.Add(x);
      }

      private void btnCancelMultiple_Click(object sender, EventArgs e)
      {
         var strArr = txtCancelMultiple.Text.Split(',');
         var ints = strArr.Select(s => Convert.ToInt32(s)).ToArray();
         var x = BfExchange.Api.CancelMultipleOrders(ints);
      }

      private void btnGetDataFromCallType_Click(object sender, EventArgs e)
      {
         var callType = (BtcInfo.BitfinexUnauthenicatedCallsEnum)cbCallTypes.SelectedItem;
         switch (callType)
         {
            case BtcInfo.BitfinexUnauthenicatedCallsEnum.pubticker:
               var x = BfExchange.Api.GetPublicTicker(ExchangeConnectivity.Instance.PairType, callType);
               lbGenericData.Items.Add(x.ToString());
               break;
            case BtcInfo.BitfinexUnauthenicatedCallsEnum.stats:
               var pairStats = BfExchange.Api.GetPairStats(ExchangeConnectivity.Instance.PairType, callType);
               foreach (var pairStat in pairStats)
               {
                  lbGenericData.Items.Add(pairStat.ToString());
               }
               break;
            case BtcInfo.BitfinexUnauthenicatedCallsEnum.trades:
               IList<BitfinexTradesGet> bfTrades = BfExchange.Api.GetPairTrades(ExchangeConnectivity.Instance.PairType, callType);
               foreach (var bfTrade in bfTrades)
               {
                  lbGenericData.Items.Add(bfTrade.ToString());
               }
               break;
         }

      }

      private void cbSymbols_SelectedIndexChanged(object sender, EventArgs e)
      {
         var pairType = (BtcInfo.PairTypeEnum)cbPair.SelectedItem;
         ExchangeConnectivity.Instance.SetGlobalPairType(pairType);
      }

      private void cbCallTypes_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void btnGetSymbols_Click(object sender, EventArgs e)
      {
         var symbols = BfExchange.Api.GetSymbols();
         foreach (var symbol in symbols)
         {
            lbGenericData.Items.Add(symbol.ToString());
         }
      }

      private void btnGetLendbook_Click(object sender, EventArgs e)
      {
         var lendbook = BfExchange.Api.GetLendbook(cbSymbols.SelectedItem.ToString().ToLower());
         foreach (var ask in lendbook.Asks)
         {
            lbGenericData.Items.Add(ask.ToString());
         }

         foreach (var bid in lendbook.Bids)
         {
            lbGenericData.Items.Add(bid.ToString());
         }

      }

      private void btnGetLends_Click(object sender, EventArgs e)
      {
         var lends = BfExchange.Api.GetLends(cbSymbols.SelectedItem.ToString().ToLower());
         foreach (var lend in lends)
         {
            lbGenericData.Items.Add(lend.ToString());
         }
      }

      private void btnGetActiveOrders_Click(object sender, EventArgs e)
      {
         var activeOrders = BfExchange.Api.GetActiveOrders();
         foreach (var activeOrder in activeOrders)
         {
            lbGenericData.Items.Add(activeOrder.ToString());
         }
      }

      private void btnGetActivePos_Click(object sender, EventArgs e)
      {
         var activePositions = BfExchange.Api.GetActivePositions();
         lbGenericData.Items.Add(activePositions);
      }

      private void btnGetHistory_Click(object sender, EventArgs e)
      {
         var symbol = (BtcInfo.ExchangeSymbolEnum)cbSymbols.SelectedItem;
         var since = Common.GetTimeStamp(DateTime.Today.AddDays(-10));
         var until = Common.GetTimeStamp(DateTime.Today);
         int limit = 100;
         var wallet = (BtcInfo.BitfinexWalletEnum)cbWalletType.SelectedItem;

         var history = BfExchange.Api.GetHistory(symbol.ToString().ToLower(), since.ToString(), until.ToString(), limit, wallet.ToString());

         foreach (var h in history)
         {
            lbGenericData.Items.Add(h.ToString());
         }
      }

      private void btnGetMyTrades_Click(object sender, EventArgs e)
      {
         var pair = cbPair.SelectedItem.ToString().ToLower();
         var since = Common.GetTimeStamp(DateTime.Today.AddDays(-10));
         int limit = 100;

         var myTrades = BfExchange.Api.GetMyTrades(pair, since.ToString(), limit);

         foreach (var trade in myTrades)
         {
            lbGenericData.Items.Add(trade.ToString());
         }

      }

      private void btnDeposit_Click(object sender, EventArgs e)
      {
         var symbol = cbSymbols.SelectedItem.ToString().ToUpper();
         var method = BtcInfo.SymbolMapHelper[(BtcInfo.ExchangeSymbolEnum)cbSymbols.SelectedItem].ToString().ToLower();
         var depositTo = cbDepositTo.SelectedItem.ToString();

         var depositResult = BfExchange.Api.Deposit(symbol, method, depositTo);
         lbGenericData.Items.Add(depositResult.ToString());

      }

      private void btnAccountInfo_Click(object sender, EventArgs e)
      {
         var accountInfo = BfExchange.Api.GetAccountInformation();
         lbGenericData.Items.Add(accountInfo.ToString());
      }

      private void btnMarginInfo_Click(object sender, EventArgs e)
      {
         var marginInfo = BfExchange.Api.GetMarginInformation();
         lbGenericData.Items.Add(marginInfo.ToString());
      }

      private void btnSendNewOffer_Click(object sender, EventArgs e)
      {
         try
         {
            var currency = cbCurrency.SelectedItem.ToString().ToUpper();
            var amount = Convert.ToDecimal(txtOfferAmount.Text);
            var rate = Convert.ToDecimal(txtRate.Text) * 365;
            var period = Convert.ToInt32(txtDays.Text);
            var direction = cbDirection.SelectedItem.ToString();

            var newOffer = new BitfinexNewOfferPost
            {
               Currency = currency,
               Amount = amount.ToString(),
               Rate = rate.ToString(),
               Period = period,
               Direction = direction
            };

            var newOfferResult = BfExchange.Api.SendNewOffer(newOffer);
            lbGenericData.Items.Add(newOfferResult.ToString());

         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }

      private void btnCancelOffer_Click(object sender, EventArgs e)
      {
         var cancelledOffer = BfExchange.Api.CancelOffer(Convert.ToInt32(txtOrderId.Text));
         lbLogger.Items.Add(cancelledOffer.ToString());
      }

      private void btnGetOfferStatus_Click(object sender, EventArgs e)
      {
         var offerStatus = BfExchange.Api.GetOfferStatus(Convert.ToInt32(txtOrderId.Text));
         lbLogger.Items.Add(offerStatus.ToString());
         
      }

      private void btnGetActiveOffers_Click(object sender, EventArgs e)
      {
         var activeOffers = BfExchange.Api.GetActiveOffers();
         foreach (var activeOffer in activeOffers)
         {
            lbGenericData.Items.Add(activeOffer.ToString());
         }
      }

      private void btnGetActiveCredits_Click(object sender, EventArgs e)
      {
         var activeCredits = BfExchange.Api.GetActiveCredits();
         foreach (var activeCredit in activeCredits)
         {
            lbGenericData.Items.Add(activeCredit.ToString());
         }
      }

      private void btnGetActiveSwapsInMarginPos_Click(object sender, EventArgs e)
      {
         var activeSwapsInMargin = BfExchange.Api.GetActiveSwapsUsedInMarginPosition();

         foreach (var activeSwaps in activeSwapsInMargin)
         {
            lbGenericData.Items.Add(activeSwaps.ToString());
         }

      }

      private void btnCloseSwap_Click(object sender, EventArgs e)
      {
         var closeSwapResult = BfExchange.Api.CloseSwap(Convert.ToInt32(txtOrderId.Text));
         lbGenericData.Items.Add(closeSwapResult.ToString());
      }

      private void btnClaimPosition_Click(object sender, EventArgs e)
      {
         var claimPosResult = BfExchange.Api.ClaimPosition(Convert.ToInt32(txtOrderId.Text));
         lbGenericData.Items.Add(claimPosResult.ToString());
      }
   }
}
