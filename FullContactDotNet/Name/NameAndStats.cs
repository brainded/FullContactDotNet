namespace FullContactDotNet.Name
{
    public class NameAndStats
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the given.
        /// </summary>
        /// <value>
        /// The given.
        /// </value>
        public GivenNameStats Given { get; set; }

        /// <summary>
        /// Gets or sets the family.
        /// </summary>
        /// <value>
        /// The family.
        /// </value>
        public FamilyNameStats Family { get; set; }
    }
}
