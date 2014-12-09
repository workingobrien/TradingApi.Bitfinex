using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexDepositResponse
   {
      [JsonProperty("result")]
      public string Result { get; set; }

      [JsonProperty("method")]
      public string Method { get; set; }

      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("address")]
      public string Address { get; set; }

      public override string ToString()
      {
         var str = string.Format("Result: {0}, Method: {1}, Currency: {2}, Address: {3}",Result,Method,Currency,Address);
         return str;
      }
   }
}
