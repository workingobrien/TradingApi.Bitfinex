using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexDepositPost : BitfinexPostBase
   {
      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("method")]
      public string Method { get; set; }

      [JsonProperty("wallet_name")]
      public string WalletName { get; set; }
   }
}
