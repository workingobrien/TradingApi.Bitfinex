using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexHistoryPost : BitfinexPostBase
   {
      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("since")]
      public string Since { get; set; }

      [JsonProperty("until")]
      public string Until { get; set; }

      [JsonProperty("limit")]
      public int Limit { get; set; }

      [JsonProperty("wallet")]
      public string Wallet { get; set; }
   }
}
