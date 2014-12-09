using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexHistoryResponse
   {
      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("balance")]
      public string Balance { get; set; }

      [JsonProperty("description")]
      public string Description { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      public override string ToString()
      {
         var str = string.Format("Currency: {0}, Amount: {1}, Balance: {2}, Desc: {3}, Timestamp: {4}",
            Currency,Amount,Balance,Description,Timestamp);
         return str;
      }
   }
}
