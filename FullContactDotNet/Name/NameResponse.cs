namespace FullContactDotNet.Name
{
    public class NameResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the likelihood.
        /// </summary>
        /// <value>
        /// The likelihood.
        /// </value>
        public double Likelihood { get; set; }

        /// <summary>
        /// Gets or sets the name details.
        /// </summary>
        /// <value>
        /// The name details.
        /// </value>
        public NameDetails NameDetails { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public string Region { get; set; }
    }
}
