namespace FullContactDotNet.Entities
{
    public class Country
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Country"/> is deduced.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deduced; otherwise, <c>false</c>.
        /// </value>
        public bool Deduced { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }
    }
}
