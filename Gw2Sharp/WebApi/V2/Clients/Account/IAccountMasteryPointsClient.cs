using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 account mastery points endpoint.
    /// </summary>
    public interface IAccountMasteryPointsClient : 
        IAuthenticatedClient,
        IBlobClient<AccountMasteryPoints>
    {
    }
}
