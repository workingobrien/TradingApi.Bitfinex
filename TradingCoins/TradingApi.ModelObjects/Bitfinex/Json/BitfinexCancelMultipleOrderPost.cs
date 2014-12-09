using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexCancelMultipleOrderPost : BitfinexPostBase
   {
      [JsonProperty("order_ids")]
      public int[] OrderIds { get; set; }
   }
}
