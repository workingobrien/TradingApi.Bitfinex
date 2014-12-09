using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexPublicTickerGet
   {

      [JsonProperty("mid")]
      public string Mid { get; set; }

      [JsonProperty("bid")]
      public string Bid { get; set; }

      [JsonProperty("ask")]
      public string Ask { get; set; }

      [JsonProperty("last_price")]
      public string LastPrice { get; set; }

      [JsonProperty("low")]
      public string Low { get; set; }

      [JsonProperty("high")]
      public string High { get; set; }

      [JsonProperty("volume")]
      public string Volume { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      public override string ToString()
      {
         var str = string.Format("mid: {0}, bid: {1}, ask: {2}, last: {3}, low: {4}, high: {5} volume: {6}, timestamp: {7}",
                                 Mid, Bid, Ask, LastPrice, Low, High, Volume, Timestamp);
         return str;
      }
   }
}
