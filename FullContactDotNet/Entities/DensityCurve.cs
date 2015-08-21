namespace FullContactDotNet.Entities
{
    public class DensityCurve
    {
        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public Mode Mode { get; set; }

        /// <summary>
        /// Gets or sets the mean age.
        /// </summary>
        /// <value>
        /// The mean age.
        /// </value>
        public double MeanAge { get; set; }

        /// <summary>
        /// Gets or sets the quartiles.
        /// </summary>
        /// <value>
        /// The quartiles.
        /// </value>
        public Quartiles Quartiles { get; set; }
    }
}