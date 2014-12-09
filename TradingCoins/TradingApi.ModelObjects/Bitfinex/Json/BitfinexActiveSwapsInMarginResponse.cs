using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexActiveSwapsInMarginResponse
   {
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("position_id")]
      public int PositionId { get; set; }

      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("rate")]
      public string Rate { get; set; }

      public decimal DailyRate
      {
         get
         {
            if (string.IsNullOrEmpty(Rate))
               return decimal.MinValue;

            var rate = Convert.ToDecimal(Rate);
            return rate / 365;
         }
      }

      [JsonProperty("period")]
      public int Period { get; set; }

      [JsonProperty("amount")]
      public string Amount { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      public override string ToString()
      {
         var str =
            string.Format(
               "Id: {0}, PositionId: {1}, Currency: {2}, Rate: {3}, Daily Rate: {4}, Period: {5}, Amount: {6}, Timestamp: {7}",
               Id, PositionId, Currency, Rate, DailyRate, Period, Amount, Timestamp);
         return str;
      }
   }
}
