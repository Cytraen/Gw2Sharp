using System.Collections.Generic;

namespace Gw2Sharp.WebApi.V2.Models
{
    /// <summary>
    /// Represents a finisher.
    /// </summary>
    public class Finisher : IIdentifiable<int>
    {
        /// <summary>
        /// The finisher id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The finisher unlock details.
        /// </summary>
        public string UnlockDetails { get; set; }

        /// <summary>
        /// The items that unlock this finisher.
        /// Each element can be resolved against <see cref="IGw2WebApiV2Client.Items"/>.
        /// </summary>
        public IReadOnlyList<int> UnlockItems { get; set; }

        /// <summary>
        /// The finisher order.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// The finisher icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The finisher name.
        /// </summary>
        public string Name { get; set; }
    }
}
