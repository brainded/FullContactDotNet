using RestSharp.Deserializers;

namespace FullContactDotNet.Entities
{
    public class NameSimilarityResult
    {
        /// <summary>
        /// Gets or sets the first string.
        /// </summary>
        /// <value>
        /// The first string.
        /// </value>
        [DeserializeAs(Name = "SimMetrics")]
        public SimilarityMetrics SimilarityMetrics { get; set; }

        /// <summary>
        /// Gets or sets the second string.
        /// </summary>
        /// <value>
        /// The second string.
        /// </value>
        public LevelTwoSimilarityMetrics SecondString { get; set; }

        /// <summary>
        /// Gets or sets the full contact.
        /// </summary>
        /// <value>
        /// The full contact.
        /// </value>
        public FullContactMetrics FullContact { get; set; }
    }
}