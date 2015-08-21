using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class DistanceMeasurement : SimilarityMeasurement
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public int Distance { get; set; }
    }
}
