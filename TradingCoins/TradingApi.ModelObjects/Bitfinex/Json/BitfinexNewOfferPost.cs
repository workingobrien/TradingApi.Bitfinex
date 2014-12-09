using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexNewOfferPost : BitfinexPostBase
   {
      [JsonProperty("currency")]
      public string Currency { get; set; }
      
      [JsonProperty("amount")]
      public string Amount { get; set; }
      
      [JsonProperty("rate")]
      public string Rate { get; set; }

      public decimal DailyRate
      {
         get
         {
            if (string.IsNullOrEmpty(Rate))
               return decimal.MinValue;

            var rate = Convert.ToDecimal(Rate);
            return rate / 365;
         }
      }
      [JsonProperty("period")]
      public int Period { get; set; }
      
      [JsonProperty("direction")]
      public string Direction { get; set; }
   }

}
