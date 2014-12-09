using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexOfferStatusPost : BitfinexPostBase
   {
      [JsonProperty("offer_id")]
      public int OfferId { get; set; }

   }
}
