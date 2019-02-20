using System;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 commerce transactions history buys endpoint.
    /// </summary>
    [EndpointPath("commerce/transactions/history/buys")]
    public class CommerceTransactionsHistoryBuysClient : BaseEndpointPaginatedBlobClient<CommerceTransactionHistory>, ICommerceTransactionsHistoryBuysClient
    {
        /// <summary>
        /// Creates a new <see cref="CommerceTransactionsHistoryBuysClient"/> that is used for the API v2 commerce transactions history buys endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="connection"/> is <c>null</c>.</exception>
        public CommerceTransactionsHistoryBuysClient(IConnection connection) :
            base(connection)
        { }
    }
}
