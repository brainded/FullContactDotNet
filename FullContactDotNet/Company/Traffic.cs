using System.Collections.Generic;

namespace FullContactDotNet.Company
{
    public class Traffic
    {
        /// <summary>
        /// Gets or sets the top country ranking.
        /// </summary>
        /// <value>
        /// The top country ranking.
        /// </value>
        public List<Ranking> TopCountryRanking { get; set; }

        /// <summary>
        /// Gets or sets the ranking.
        /// </summary>
        /// <value>
        /// The ranking.
        /// </value>
        public List<Ranking> Ranking { get; set; }
    }
}
