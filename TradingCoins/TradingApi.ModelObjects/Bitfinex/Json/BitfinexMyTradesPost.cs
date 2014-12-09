using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexMyTradesPost : BitfinexPostBase
   {
      [JsonProperty("symbol")]
      public string Symbol { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }
     
      [JsonProperty("limit_trades")]
      public int Limit { get; set; }

   }
}
