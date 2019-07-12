using System;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 novelties endpoint.
    /// </summary>
    [EndpointPath("novelties")]
    public class NoveltiesClient : BaseEndpointBulkAllClient<Novelty, int>, INoveltiesClient
    {
        /// <summary>
        /// Creates a new <see cref="NoveltiesClient"/> that is used for the API v2 novelties endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="connection"/> is <c>null</c>.</exception>
        public NoveltiesClient(IConnection connection) :
            base(connection)
        { }
    }
}