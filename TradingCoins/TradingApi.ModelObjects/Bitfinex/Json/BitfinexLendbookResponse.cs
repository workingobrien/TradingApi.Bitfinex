
using Newtonsoft.Json;
using TradingApi.ModelObjects.Bitfinex.Json.LendbookTypes;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexLendbookResponse
   {
      [JsonProperty("bids")]
      public Bid[] Bids { get; set; }

      [JsonProperty("asks")]
      public Ask[] Asks { get; set; }
   }
}
