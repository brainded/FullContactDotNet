namespace FullContactDotNet.Entities
{
    public class GivenNameStats : NameStats
    {
        /// <summary>
        /// Gets or sets the male.
        /// </summary>
        /// <value>
        /// The male.
        /// </value>
        public Sex Male { get; set; }

        /// <summary>
        /// Gets or sets the female.
        /// </summary>
        /// <value>
        /// The female.
        /// </value>
        public Sex Female { get; set; }
    }
}