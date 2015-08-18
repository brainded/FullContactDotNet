namespace FullContactDotNet.Entities
{
    public class LocationDeduced
    {
        /// <summary>
        /// Gets or sets the normalized location.
        /// </summary>
        /// <value>
        /// The normalized location.
        /// </value>
        public string NormalizedLocation { get; set; }

        /// <summary>
        /// Gets or sets the deduced location.
        /// </summary>
        /// <value>
        /// The deduced location.
        /// </value>
        public string DeducedLocation { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public City City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public State State { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the continent.
        /// </summary>
        /// <value>
        /// The continent.
        /// </value>
        public Continent Continent { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public County County { get; set; }

        /// <summary>
        /// Gets or sets the likelihood.
        /// </summary>
        /// <value>
        /// The likelihood.
        /// </value>
        public int Likelihood { get; set; }
    }
}
