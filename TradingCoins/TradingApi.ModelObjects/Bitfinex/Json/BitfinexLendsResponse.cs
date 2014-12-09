using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexLendsResponse
   {
      [JsonProperty("rate")]
      public string Rate { get; set; }

      [JsonProperty("amount_lent")]
      public string AmountLent { get; set; }

      [JsonProperty("timestamp")]
      public int Timestamp { get; set; }

      public override string ToString()
      {
         var str = string.Format("Rate: {0}, AmountLent: {1}, Timestamp: {2}", Rate, AmountLent, Timestamp);
         return str;
      }
   }
}
