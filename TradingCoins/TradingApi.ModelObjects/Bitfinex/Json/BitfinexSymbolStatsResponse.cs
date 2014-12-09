using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexSymbolStatsResponse
   {
      [JsonProperty("period")]
      public int Period { get; set; }

      [JsonProperty("volume")]
      public string Volume { get; set; }

      public override string ToString()
      {
         var str = string.Format("Period: {0}, Volume: {1}", Period, Volume);
         return str;
      }
   }
}
