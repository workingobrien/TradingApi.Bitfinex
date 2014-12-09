using Newtonsoft.Json;
using TradingApi.ModelObjects.Bitfinex.Json.MultipleOrderTypes;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexMultipleNewOrderResponse
   {
      [JsonProperty("order_ids")]
      public OrderId[] OrderIds { get; set; }

      [JsonProperty("status")]
      public string Status { get; set; }

   }
}
