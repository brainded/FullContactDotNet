namespace FullContactDotNet.Name
{
    public class NameParsed
    {
        /// <summary>
        /// Gets or sets the name of the given.
        /// </summary>
        /// <value>
        /// The name of the given.
        /// </value>
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the name of the family.
        /// </summary>
        /// <value>
        /// The name of the family.
        /// </value>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the likelihood.
        /// </summary>
        /// <value>
        /// The likelihood.
        /// </value>
        public double Likelihood { get; set; }
    }
}