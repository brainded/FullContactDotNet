using FullContactDotNet.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet
{
    public interface IFullContactLocationApi
    {
        /// <summary>
        /// Gets the normalized location.
        /// </summary>
        /// <param name="place">The place.</param>
        /// <param name="includeZeroPopulation">The include zero population.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NormalizedLocationResponse GetNormalizedLocation(string place, bool? includeZeroPopulation = null, Casing? casing = null);

        /// <summary>
        /// Gets the enriched location.
        /// </summary>
        /// <param name="place">The place.</param>
        /// <param name="includeZeroPopulation">The include zero population.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        EnrichedLocationResponse GetEnrichedLocation(string place, bool? includeZeroPopulation = null, Casing? casing = null);
    }
}
