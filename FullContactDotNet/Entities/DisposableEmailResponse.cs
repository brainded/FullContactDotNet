using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class DisposableEmailResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the username sub addressing.
        /// </summary>
        /// <value>
        /// The username sub addressing.
        /// </value>
        public string UsernameSubAddressing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [disposable email domain].
        /// </summary>
        /// <value>
        /// <c>true</c> if [disposable email domain]; otherwise, <c>false</c>.
        /// </value>
        public bool DisposableEmailDomain { get; set; }
    }
}
