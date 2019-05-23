using System.Threading.Tasks;

using CryptoCompare;

using Xunit;

namespace Cryptocompare.Integration.Tests.Clients
{
    public class PairsClientTests
    {
        [Fact]
        public async Task CanCallLatestMappingExchangeEndpoint()
        {
            var result = await CryptoCompareClient.Instance.Pairs.ListAsync();
            Assert.NotNull(result);
        }

    }
}
