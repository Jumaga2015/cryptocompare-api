using System.Net.Http;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace CryptoCompare
{
    /// <summary>
    /// The Pairs client. Gets general info for all the Pairs available on the website.
    /// </summary>
    /// <seealso cref="T:CryptoCompare.Clients.IPairsClient"/>
    public class PairsClient : BaseApiClient, IPairsClient
    {
        /// <summary>
        /// Initializes a new instance of the CryptoCompare.Clients.PairsClient class.
        /// </summary>
        /// <param name="httpClient">The HTTP client. This cannot be null.</param>
        public PairsClient([NotNull] HttpClient httpClient)
            : base(httpClient)
        {
        }

        /// <summary>
        /// Returns all the Pairs that CryptoCompare has added to the website.
        /// </summary>
        /// <seealso cref="M:CryptoCompare.Clients.IPairsClient.AllPairsAsync()"/>
        public async Task<PairListAllResponse> ListAsync()
        {
            return await this.GetAsync<PairListAllResponse>(ApiUrls.AllPairs()).ConfigureAwait(false);
        }

    }
}
