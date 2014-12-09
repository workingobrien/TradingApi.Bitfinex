using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexMyTradesResponse
   {
      [JsonProperty("price")]
      public string Price { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      [JsonProperty("exchange")]
      public string Exchange { get; set; }

      [JsonProperty("type")]
      public string Type { get; set; }

      [JsonProperty("fee_currency")]
      public string FeeCurrency { get; set; }

      [JsonProperty("fee_amount")]
      public string FeeAmount { get; set; }

      [JsonProperty("tid")]
      public int Tid { get; set; }

      [JsonProperty("order_id")]
      public int OrderId { get; set; }

      public override string ToString()
      {
         var str =
            string.Format(
               "Price: {0}, Amount: {1}, Timestamp: {2}, Exchange: {3}, Type: {4}, FeeCurrency: {5}, FeeAmount: {6}, Tid: {7}, OrderId: {8}",
               Price, Amount, Timestamp, Exchange, Type, FeeCurrency, FeeAmount, Tid, OrderId);
         return str;
      }
   }
}
