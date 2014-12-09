using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexOfferStatusResponse
   {

      [JsonProperty("id")]
      public int Id { get; set; }

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

      [JsonProperty("direction")]
      public string Direction { get; set; }

      [JsonProperty("timestamp")]
      public string Timestamp { get; set; }

      [JsonProperty("is_live")]
      public bool IsLive { get; set; }

      [JsonProperty("is_cancelled")]
      public bool IsCancelled { get; set; }

      [JsonProperty("original_amount")]
      public string OriginalAmount { get; set; }

      [JsonProperty("remaining_amount")]
      public string RemainingAmount { get; set; }

      [JsonProperty("executed_amount")]
      public string ExecutedAmount { get; set; }

      [JsonProperty("offer_id")]
      public int OfferId { get; set; }

      public override string ToString()
      {
         var str =
            string.Format(
               "Id: {0}, Currency: {1}, Rate: {2}, Period: {3}, Direction: {4}, Timestamp: {5}, IsLive: {6}" +
               "IsCancelled: {7}, OrigAmount: {8}, RemainingAmt: {9}, ExeAmt: {10}, OfferId: {11}",
               Id,Currency,Rate,Period,Direction,Timestamp,IsLive,IsCancelled,OriginalAmount,RemainingAmount,
               ExecutedAmount,OfferId);
         return str;
      }
   }
}
