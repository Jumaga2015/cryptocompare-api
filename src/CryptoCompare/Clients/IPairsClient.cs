using System.Threading.Tasks;

namespace CryptoCompare
{
    /// <summary>
    /// Pairs api client. Gets general info for all the Pairs available on the website.
    /// </summary>
    public interface IPairsClient : IApiClient
    {
        /// <summary>
        /// Returns all the Pairs that CryptoCompare has added to the website. 
        /// </summary>
        Task<PairListAllResponse> ListAsync();

    }
}
