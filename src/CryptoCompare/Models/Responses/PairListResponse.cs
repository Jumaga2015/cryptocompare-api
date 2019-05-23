using System.Collections.Generic;

using Newtonsoft.Json;

namespace CryptoCompare
{
    /// <summary>
    /// List all pairs of all exchanges
    /// </summary>
    /// <seealso cref="T:CryptoCompare.Responses.BaseApiResponse"/>
    public class PairListAllResponse : BaseApiResponse
    {
        /// <summary>
        /// Gets or sets the Pairs data.
        /// </summary>
        [JsonProperty("Data")]
        public IReadOnlyDictionary<string, List<PairInfo>> Pairs { get; set; }
    }
}
