using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexCloseSwapPost : BitfinexPostBase
   {
      [JsonProperty("swap_id")]
      public int SwapId { get; set; }
   }
}
