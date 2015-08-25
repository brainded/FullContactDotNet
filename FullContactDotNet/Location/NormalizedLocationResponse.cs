using FullContactDotNet.Shared;

namespace FullContactDotNet.Location
{
    public class NormalizedLocationResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public NameAndCode State { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public NameAndCode Country { get; set; }

        /// <summary>
        /// Gets or sets the continent.
        /// </summary>
        /// <value>
        /// The continent.
        /// </value>
        public string Continent { get; set; }

        /// <summary>
        /// Gets or sets the likelihood.
        /// </summary>
        /// <value>
        /// The likelihood.
        /// </value>
        public string Likelihood { get; set; }

        /// <summary>
        /// Gets or sets the normalized location.
        /// </summary>
        /// <value>
        /// The normalized location.
        /// </value>
        public string NormalizedLocation { get; set; }
    }
}
