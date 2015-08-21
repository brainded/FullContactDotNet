namespace FullContactDotNet.Name
{
    public class Sex
    {
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the likelihood.
        /// </summary>
        /// <value>
        /// The likelihood.
        /// </value>
        public double Likelihood { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>
        /// The rank.
        /// </value>
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets the frequency ratio.
        /// </summary>
        /// <value>
        /// The frequency ratio.
        /// </value>
        public double FrequencyRatio { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public Age Age { get; set; }
    }
}