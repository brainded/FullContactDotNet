using System.Collections.Generic;

namespace FullContactDotNet.Company
{
    public class CompanyResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public List<NameAndCode> Category { get; set; }

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the language locale.
        /// </summary>
        /// <value>
        /// The language locale.
        /// </value>
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Gets or sets the organization.
        /// </summary>
        /// <value>
        /// The organization.
        /// </value>
        public Organization Organization { get; set; }

        /// <summary>
        /// Gets or sets the social profiles.
        /// </summary>
        /// <value>
        /// The social profiles.
        /// </value>
        public List<SocialProfile> SocialProfiles { get; set; }

        /// <summary>
        /// Gets or sets the traffic.
        /// </summary>
        /// <value>
        /// The traffic.
        /// </value>
        public Traffic Traffic { get; set; }
    }
}
