using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.CardReader
{
    public class CardReaderResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CardReaderResponse"/> is queued.
        /// </summary>
        /// <value>
        ///   <c>true</c> if queued; otherwise, <c>false</c>.
        /// </value>
        public bool Queued { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the estimated wait time minutes.
        /// </summary>
        /// <value>
        /// The estimated wait time minutes.
        /// </value>
        public int EstimatedWaitTimeMinutes { get; set; }
    }
}
