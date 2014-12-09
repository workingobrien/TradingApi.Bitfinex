using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexMultipleNewOrdersPost : BitfinexPostBase
   {
      [JsonProperty("orders")]
      public BitfinexNewOrderPost[] Orders { get; set; }

   }
}
