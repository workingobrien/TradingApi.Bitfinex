using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cob.TradingApps.BtcData;
using Cob.TradingApps.BtcData.Exchanges;
using TradingApi.ModelObjects;
using TradingApi.ModelObjects.Bitfinex.Json;

namespace TradingCoins.Controls
{
   public partial class ExchangeAcctCtrl : UserControl
   {
      private Form1 _frm;

      public ExchangeAcctCtrl(Form1 form1)
      {
         InitializeComponent();
         _frm = form1;
         cbBuySell.Items.Add("buy");
         cbBuySell.Items.Add("sell");
      }

      public BitfinexExchange Exchange
      {
         get { return ExchangeConnectivity.Instance.Exchanges[BtcInfo.ExchangeEnum.BITFINEX] as BitfinexExchange; }
      }

      private void btnSend_Click(object sender, EventArgs e)
      {
         try
         {
            var price = decimal.Parse(txtPrice.Text);
            var amount = decimal.Parse(txtSize.Text);
            var side = cbBuySell.Text;
            var orderResponse = Exchange.Api.SendSimpleLimit("ltcusd", amount.ToString(), price.ToString(), side);
         }
         catch (Exception ex)
         {
            
         }
      }

      private void btnSendMultiple_Click(object sender, EventArgs e)
      {
         var price = decimal.Parse(txtPrice.Text);
         var amount = decimal.Parse(txtSize.Text);
         var side = cbBuySell.Text;

         var orderList = new List<BitfinexNewOrderPost>();
         var order1 = new BitfinexNewOrderPost();
         order1.Amount = amount.ToString();
         order1.Exchange = "bitfinex";
         order1.Price = price.ToString();
         order1.Side = side;
         order1.Symbol = _frm.cbPair.SelectedItem.ToString().ToLower();
         order1.Type = "exchange limit";

         orderList.Add(order1);
         
         order1 = new BitfinexNewOrderPost();
         order1.Amount = amount.ToString();
         order1.Exchange = "bitfinex";
         if (side == "buy")
            order1.Price = decimal.Subtract(price, .50m).ToString();
         else
         {
            order1.Price = decimal.Add(price, .50m).ToString();
         }
         order1.Side = side;
         order1.Symbol = _frm.cbPair.SelectedItem.ToString().ToLower();
         order1.Type = "exchange limit";

         orderList.Add(order1);

         var x = Exchange.Api.SendMultipleOrders(orderList.ToArray());
      }

      private void button1_Click(object sender, EventArgs e)
      {
         //var bfExchange = ExchangeConnectivity.Instance.Exchanges[BtcInfo.ExchangeEnum.BITFINEX] as BitfinexExchange;
         if (Exchange != null)
         {
            var balances = Exchange.Api.GetBalances();
            foreach (var balance in balances)
            {
               txtBalances.Text = balance.ToString();
            }
         }

      }

      private void btnCancelReplace_Click(object sender, EventArgs e)
      {
         var price = decimal.Parse(txtPrice.Text);
         var amount = decimal.Parse(txtSize.Text);
         var side = cbBuySell.Text;

         var order = new BitfinexNewOrderPost();
         order.Side = side;
         if (side == "buy")
         {
            order.Price = decimal.Subtract(price, .05m).ToString();
            order.Amount = decimal.Subtract(amount, .20m).ToString();
         }
         else
         {
            order.Price = decimal.Add(price, .05m).ToString();
            order.Amount = decimal.Subtract(amount, .20m).ToString();
         }
         order.Exchange = "bitfinex";
         order.Symbol = "ltcusd";
         order.Type = "exchange limit";

         Exchange.Api.CancelReplaceOrder(Convert.ToInt32(txtCancelReplaceId.Text), order);
      }


   }
}
