namespace FullContactDotNet.Account
{
    public class Metric
    {
        /// <summary>
        /// Gets or sets the name of the metric.
        /// </summary>
        /// <value>
        /// The name of the metric.
        /// </value>
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets the metric identifier.
        /// </summary>
        /// <value>
        /// The metric identifier.
        /// </value>
        public string MetricId { get; set; }

        /// <summary>
        /// Gets or sets the plan level.
        /// </summary>
        /// <value>
        /// The plan level.
        /// </value>
        public int PlanLevel { get; set; }

        /// <summary>
        /// Gets or sets the usage.
        /// </summary>
        /// <value>
        /// The usage.
        /// </value>
        public int Usage { get; set; }

        /// <summary>
        /// Gets or sets the remaining.
        /// </summary>
        /// <value>
        /// The remaining.
        /// </value>
        public int Remaining { get; set; }

        /// <summary>
        /// Gets or sets the overage.
        /// </summary>
        /// <value>
        /// The overage.
        /// </value>
        public int Overage { get; set; }
    }
}