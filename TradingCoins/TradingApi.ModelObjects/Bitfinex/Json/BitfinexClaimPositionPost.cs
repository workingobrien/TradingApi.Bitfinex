using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexClaimPositionPost : BitfinexPostBase
   {
      [JsonProperty("position_id")]
      public int PositionId { get; set; }
   }
}
