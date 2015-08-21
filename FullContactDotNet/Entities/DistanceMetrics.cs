using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class DistanceMetrics
    {
        /// <summary>
        /// Gets or sets the similarity.
        /// </summary>
        /// <value>
        /// The similarity.
        /// </value>
        public double Similarity { get; set; }

        /// <summary>
        /// Gets or sets the time estimated.
        /// </summary>
        /// <value>
        /// The time estimated.
        /// </value>
        public double TimeEstimated { get; set; }

        /// <summary>
        /// Gets or sets the time actual.
        /// </summary>
        /// <value>
        /// The time actual.
        /// </value>
        public int TimeActual { get; set; }
    }
}
