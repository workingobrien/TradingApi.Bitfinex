using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TradingApi.ModelObjects.Bitfinex.Json.MarginInfoTypes;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexMarginInfoResponse
   {

      [JsonProperty("margin_balance")]
      public string MarginBalance { get; set; }

      [JsonProperty("tradable_balance")]
      public string TradableBalance { get; set; }

      [JsonProperty("unrealized_pl")]
      public string UnrealizedPl { get; set; }

      [JsonProperty("unrealized_swap")]
      public string UnrealizedSwap { get; set; }

      [JsonProperty("net_value")]
      public string NetValue { get; set; }

      [JsonProperty("required_margin")]
      public string RequiredMargin { get; set; }

      [JsonProperty("leverage")]
      public string Leverage { get; set; }

      [JsonProperty("margin_requirement")]
      public string MarginRequirement { get; set; }

      [JsonProperty("margin_limits")]
      public MarginLimit[] MarginLimits { get; set; }

      [JsonProperty("message")]
      public string Message { get; set; }

      public override string ToString()
      {
         var str = string.Format("MarginBalance: {0}, TradeableBalance: {1}, UnrealizedPl: {2}" +
                                 "UnrealizedSwap: {3}, NetValue: {4}, RequiredMargin: {5}, Leverage: {6}" +
                                 "MarginRequirement: {7}, Message: {8}", MarginBalance, TradableBalance, UnrealizedPl,
                                 UnrealizedSwap, NetValue, RequiredMargin, Leverage, MarginRequirement, Message);
         return str;
      }
   }
}
