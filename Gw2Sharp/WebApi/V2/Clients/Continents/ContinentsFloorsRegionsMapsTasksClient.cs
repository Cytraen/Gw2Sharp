using System;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 continents floors regions maps tasks endpoint.
    /// </summary>
    [EndpointPath("continents/:continent_id/floors/:floor_id/regions/:region_id/maps/:map_id/tasks")]
    [EndpointPathSegment("continent_id", 0)]
    [EndpointPathSegment("floor_id", 1)]
    [EndpointPathSegment("region_id", 2)]
    [EndpointPathSegment("map_id", 3)]
    public class ContinentsFloorsRegionsMapsTasksClient : BaseEndpointBulkAllClient<ContinentFloorRegionMapTask, int>, IContinentsFloorsRegionsMapsTasksClient
    {
        /// <summary>
        /// Creates a new <see cref="ContinentsFloorsRegionsMapsTasksClient"/> that is used for the API v2 characters floors regions maps tasks endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        /// <param name="continentId">The continent id.</param>
        /// <param name="floorId">The floor id.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="mapId">The map id.</param>
        /// <exception cref="ArgumentNullException"><paramref name="connection"/> is <c>null</c>.</exception>
        public ContinentsFloorsRegionsMapsTasksClient(IConnection connection, int continentId, int floorId, int regionId, int mapId) :
            base(connection, continentId.ToString(), floorId.ToString(), regionId.ToString(), mapId.ToString())
        {
            this.ContinentId = continentId;
            this.FloorId = floorId;
            this.RegionId = regionId;
            this.MapId = mapId;
        }

        /// <inheritdoc />
        public virtual int ContinentId { get; protected set; }

        /// <inheritdoc />
        public virtual int FloorId { get; protected set; }

        /// <inheritdoc />
        public virtual int RegionId { get; protected set; }

        /// <inheritdoc />
        public virtual int MapId { get; protected set; }
    }
}