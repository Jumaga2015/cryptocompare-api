using System;
using Newtonsoft.Json;

namespace CryptoCompare
{
    /// <summary>
    /// Information about the pair. (Pair list endpoint)
    /// </summary>
    public class PairInfo
    {
        public string Exchange { get; set; }
        public string Exchange_Fsym { get; set; }
        public string Exchange_Tsym { get; set; }
        public string Fsym { get; set; }
        public string Tsym { get; set; }
        [JsonConverter(typeof(UnixTimeConverter))]
        public DateTimeOffset Last_Update { get; set; }
    }
}
