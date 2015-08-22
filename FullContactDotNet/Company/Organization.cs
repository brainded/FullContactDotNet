using System.Collections.Generic;

namespace FullContactDotNet.Company
{
    public class Organization
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the approx employees.
        /// </summary>
        /// <value>
        /// The approx employees.
        /// </value>
        public int ApproxEmployees { get; set; }

        /// <summary>
        /// Gets or sets the founded.
        /// </summary>
        /// <value>
        /// The founded.
        /// </value>
        public string Founded { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the contact information.
        /// </summary>
        /// <value>
        /// The contact information.
        /// </value>
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        public List<Asset> Links { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public List<Asset> Images { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        /// <value>
        /// The keywords.
        /// </value>
        public List<string> Keywords { get; set; }
    }
}
