using System.Collections.Generic;

namespace FullContactDotNet.Account
{
    public class AccountStatsResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the period start.
        /// </summary>
        /// <value>
        /// The period start.
        /// </value>
        public string PeriodStart { get; set; }

        /// <summary>
        /// Gets or sets the period end.
        /// </summary>
        /// <value>
        /// The period end.
        /// </value>
        public string PeriodEnd { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        /// <value>
        /// The plan.
        /// </value>
        public string Plan { get; set; }

        /// <summary>
        /// Gets or sets the plan base price.
        /// </summary>
        /// <value>
        /// The plan base price.
        /// </value>
        public int PlanBasePrice { get; set; }

        /// <summary>
        /// Gets or sets the plan overage price.
        /// </summary>
        /// <value>
        /// The plan overage price.
        /// </value>
        public double PlanOveragePrice { get; set; }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the metrics.
        /// </summary>
        /// <value>
        /// The metrics.
        /// </value>
        public List<Metric> Metrics { get; set; }
    }
}
