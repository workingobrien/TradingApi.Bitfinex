using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json.MarginInfoTypes
{
   public class MarginLimit
   {
      [JsonProperty("on_pair")]
      public string OnPair { get; set; }

      [JsonProperty("initial_margin")]
      public string InitialMargin { get; set; }

      [JsonProperty("margin_requirement")]
      public string MarginRequirement { get; set; }

      [JsonProperty("tradable_balance")]
      public string TradableBalance { get; set; }
   }
}
