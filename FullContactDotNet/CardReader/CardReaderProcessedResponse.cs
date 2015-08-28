using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.CardReader
{
    public class CardReaderProcessedResponse
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last webhook attempt.
        /// </summary>
        /// <value>
        /// The last webhook attempt.
        /// </value>
        public string LastWebhookAttempt { get; set; }

        /// <summary>
        /// Gets or sets the v card URL.
        /// </summary>
        /// <value>
        /// The v card URL.
        /// </value>
        public string vCardUrl { get; set; }

        /// <summary>
        /// Gets or sets the webhook attempts.
        /// </summary>
        /// <value>
        /// The webhook attempts.
        /// </value>
        public int WebhookAttempts { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL.
        /// </summary>
        /// <value>
        /// The webhook URL.
        /// </value>
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        public string Quality { get; set; }

        /// <summary>
        /// Gets or sets the submitted.
        /// </summary>
        /// <value>
        /// The submitted.
        /// </value>
        public string Submitted { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>
        /// The contact.
        /// </value>
        public Contact Contact { get; set; }
    }
}
