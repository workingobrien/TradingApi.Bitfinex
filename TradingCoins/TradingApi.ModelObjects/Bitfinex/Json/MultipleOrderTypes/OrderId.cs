using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json.MultipleOrderTypes
{
   public class OrderId
   {
      [JsonProperty("active")]
      public int Active { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("avg_price")]
      public string AvgPrice { get; set; }

      [JsonProperty("created_at")]
      public string CreatedAt { get; set; }

      [JsonProperty("fiat_currency")]
      public string FiatCurrency { get; set; }

      [JsonProperty("hidden")]
      public bool Hidden { get; set; }

      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("lockedperiod")]
      public object Lockedperiod { get; set; }

      [JsonProperty("maxrate")]
      public string Maxrate { get; set; }

      [JsonProperty("nopayback")]
      public object Nopayback { get; set; }

      [JsonProperty("notify")]
      public int Notify { get; set; }

      [JsonProperty("originalamount")]
      public string Originalamount { get; set; }

      [JsonProperty("pair")]
      public string Pair { get; set; }

      [JsonProperty("placed_id")]
      public object PlacedId { get; set; }

      [JsonProperty("placed_trades")]
      public object PlacedTrades { get; set; }

      [JsonProperty("price")]
      public string Price { get; set; }

      [JsonProperty("routing")]
      public string Routing { get; set; }

      [JsonProperty("status")]
      public string Status { get; set; }

      [JsonProperty("trailingprice")]
      public string Trailingprice { get; set; }

      [JsonProperty("type")]
      public string Type { get; set; }

      [JsonProperty("updated_at")]
      public string UpdatedAt { get; set; }

      [JsonProperty("user_id")]
      public int UserId { get; set; }

      [JsonProperty("vir")]
      public int Vir { get; set; }
   }
}
