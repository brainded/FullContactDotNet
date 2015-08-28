using System.Collections.Generic;

namespace FullContactDotNet.CardReader
{
    public class Contact
    {
        /// <summary>
        /// Gets or sets the photos.
        /// </summary>
        /// <value>
        /// The photos.
        /// </value>
        public List<Photo> Photos { get; set; }

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>
        /// The accounts.
        /// </value>
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or sets the urls.
        /// </summary>
        /// <value>
        /// The urls.
        /// </value>
        public List<ValueAndType> Urls { get; set; }

        /// <summary>
        /// Gets or sets the organizations.
        /// </summary>
        /// <value>
        /// The organizations.
        /// </value>
        public List<Organization> Organizations { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public Name Name { get; set; }

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        /// <value>
        /// The emails.
        /// </value>
        public List<ValueAndType> Emails { get; set; }

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>
        /// The phone numbers.
        /// </value>
        public List<ValueAndType> PhoneNumbers { get; set; }
    }

}
