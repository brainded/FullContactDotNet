using System.Collections.Generic;

namespace FullContactDotNet.Location
{
    public class EnrichedLocationResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>
        /// The locations.
        /// </value>
        public List<Location> Locations { get; set; }
    }
}
