
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexOrderStatusPost : BitfinexPostBase
   {
      /// <summary>
      /// This class can be used to send a cancel message in addition to 
      /// retrieving the current status of an order.
      /// </summary>
      [JsonProperty("order_id")]
      public int OrderId { get; set; }
   }
}
