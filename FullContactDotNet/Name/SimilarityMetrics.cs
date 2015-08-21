namespace FullContactDotNet.Name
{
    public class SimilarityMetrics
    {
        /// <summary>
        /// Gets or sets the jaro winkler.
        /// </summary>
        /// <value>
        /// The jaro winkler.
        /// </value>
        public DistanceMetrics JaroWinkler { get; set; }

        /// <summary>
        /// Gets or sets the levenshtein.
        /// </summary>
        /// <value>
        /// The levenshtein.
        /// </value>
        public DistanceMetrics Levenshtein { get; set; }
    }
}