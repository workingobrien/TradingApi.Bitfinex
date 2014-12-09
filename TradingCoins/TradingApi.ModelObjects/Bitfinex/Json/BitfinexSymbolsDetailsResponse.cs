using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexSymbolDetailsResponse
   {

      [JsonProperty("pair")]
      public string Pair { get; set; }

      [JsonProperty("price_precision")]
      public int PricePrecision { get; set; }

      [JsonProperty("initial_margin")]
      public string InitialMargin { get; set; }

      [JsonProperty("minimum_margin")]
      public string MinimumMargin { get; set; }

      [JsonProperty("maximum_order_size")]
      public string MaximumOrderSize { get; set; }

      [JsonProperty("minimum_order_size")]
      public string MinimumOrderSize { get; set; }

      [JsonProperty("expiration")]
      public string Expiration { get; set; }

      public override string ToString()
      {
         var str = string.Format("Pair: {0}, PricePrecision: {1}, InitialMargin: {2}, MinimumMargin: {3}, MaxOrderSize: {4}, MinOrderSize: {5}, Expiration: {6}",
               Pair,PricePrecision,InitialMargin,MinimumMargin,MaximumOrderSize,MinimumOrderSize,Expiration);
         return str;
      }
   }
}
