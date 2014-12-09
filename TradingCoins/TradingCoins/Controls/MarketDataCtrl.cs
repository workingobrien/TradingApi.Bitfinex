using System;
using System.Windows.Forms;
using Cob.TradingApps.BtcData;
using Cob.TradingApps.BtcData.Exchanges;
using TradingApi.ModelObjects;

namespace TradingCoins.Controls
{
   public partial class MarketDataCtrl : UserControl
   {
      public MarketDataCtrl()
      {
         InitializeComponent();
         ExchangeConnectivity.Instance.MarketDataUpdate += InstanceOnMarketDataUpdate;
      }

      private void InstanceOnMarketDataUpdate(ExchangeBase exchangeBase)
      {
         if (txtBidPx.InvokeRequired)
         {
            txtBidPx.Invoke(new EventHandler((sender, args) => UpdateGui(exchangeBase)));
         }
      }

      private void UpdateGui(ExchangeBase exchangeBase)
      {
         try
         {
            txtBidSz.Text = exchangeBase.MarketData.BidSz.ToString();
            txtBidPx.Text = exchangeBase.MarketData.Bid.ToString();
            txtAskPx.Text = exchangeBase.MarketData.Ask.ToString();
            txtAskSz.Text = exchangeBase.MarketData.AskSz.ToString();

         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }
   }
}
