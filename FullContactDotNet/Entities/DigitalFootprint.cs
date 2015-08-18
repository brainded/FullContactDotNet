using System.Collections.Generic;

namespace FullContactDotNet.Entities
{
    public class DigitalFootprint
    {
        /// <summary>
        /// Gets or sets the scores.
        /// </summary>
        /// <value>
        /// The scores.
        /// </value>
        public List<Score> Scores { get; set; }

        /// <summary>
        /// Gets or sets the topics.
        /// </summary>
        /// <value>
        /// The topics.
        /// </value>
        public List<Topic> Topics { get; set; }
    }
}
