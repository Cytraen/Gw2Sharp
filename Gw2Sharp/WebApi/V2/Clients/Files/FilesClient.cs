using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 files endpoint.
    /// </summary>
    [EndpointPath("files")]
    public class FilesClient : BaseEndpointBulkAllClient<File, string>, IFilesClient
    {
        /// <summary>
        /// Creates a new <see cref="FilesClient"/> that is used for the API v2 files endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        public FilesClient(IConnection connection) : base(connection) { }
    }
}
