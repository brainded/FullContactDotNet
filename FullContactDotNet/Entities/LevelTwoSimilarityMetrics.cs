using RestSharp.Deserializers;

namespace FullContactDotNet.Entities
{
    public class LevelTwoSimilarityMetrics
    {
        /// <summary>
        /// Gets or sets the jaro winkler.
        /// </summary>
        /// <value>
        /// The jaro winkler.
        /// </value>
        public SimilarityMeasurement JaroWinkler { get; set; }

        /// <summary>
        /// Gets or sets the levenshtein.
        /// </summary>
        /// <value>
        /// The levenshtein.
        /// </value>
        public DistanceMeasurement Levenshtein { get; set; }

        /// <summary>
        /// Gets or sets the level2 jaro winkler.
        /// </summary>
        /// <value>
        /// The level2 jaro winkler.
        /// </value>
        [DeserializeAs(Name = "level2jaroWinkler")]
        public SimilarityMeasurement Level2JaroWinkler { get; set; }

        /// <summary>
        /// Gets or sets the level2levenshtein.
        /// </summary>
        /// <value>
        /// The level2levenshtein.
        /// </value>
        [DeserializeAs(Name = "level2levenshtein")]
        public DistanceMeasurement Level2Levenshtein { get; set; }
    }
}
