using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Clients;
using Xunit;

namespace Gw2Sharp.Tests.WebApi.V2.Clients
{
    public class PvpStanadingsClientTests : BaseEndpointClientTests<IPvpStandingsClient>
    {
        protected override bool IsAuthenticated => true;

        protected override IPvpStandingsClient CreateClient(IGw2Client gw2Client) =>
            gw2Client.WebApi.V2.Pvp.Standings;

        [Theory]
        [InlineData("TestFiles.Pvp.PvpStandings.json")]
        public Task BlobTest(string file) => this.AssertBlobDataAsync(this.Client, file);
    }
}
