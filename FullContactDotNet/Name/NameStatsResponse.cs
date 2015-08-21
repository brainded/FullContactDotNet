namespace FullContactDotNet.Name
{
    public class NameStatsResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public NameAndStats Name { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public string Region { get; set; }
    }
}
