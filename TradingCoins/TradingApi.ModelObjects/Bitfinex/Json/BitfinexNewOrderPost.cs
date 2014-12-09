using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexNewOrderPost : BitfinexPostBase
   {
      [JsonProperty("symbol")]
      public string Symbol { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("price")]
      public string Price { get; set; } 

      [JsonProperty("exchange")]
      public string Exchange { get; set; }

      [JsonProperty("side")]
      public string Side { get; set; }

      [JsonProperty("type")]
      public string Type { get; set; }

      //[JsonProperty("is_hidden")]
      //public string IsHidden { get; set; }

      public override string ToString()
      {
         var str = string.Format("Symbol: {0}, Amount: {1}, Price: {2}, Exchange: {3}, Side: {4}, Type: {5}", 
                                 Symbol,Amount,Price,Exchange,Side,Type);
         return str;
      }
   }
}
