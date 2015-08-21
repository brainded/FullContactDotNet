using System.Collections.Generic;

namespace FullContactDotNet.Entities
{
    public class NameDetails
    {
        /// <summary>
        /// Gets or sets the name of the given.
        /// </summary>
        /// <value>
        /// The name of the given.
        /// </value>
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the name of the family.
        /// </summary>
        /// <value>
        /// The name of the family.
        /// </value>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the middle names.
        /// </summary>
        /// <value>
        /// The middle names.
        /// </value>
        public List<string> MiddleNames { get; set; }

        /// <summary>
        /// Gets or sets the prefixes.
        /// </summary>
        /// <value>
        /// The prefixes.
        /// </value>
        public List<string> Prefixes { get; set; }

        /// <summary>
        /// Gets or sets the suffixes.
        /// </summary>
        /// <value>
        /// The suffixes.
        /// </value>
        public List<string> Suffixes { get; set; }

        /// <summary>
        /// Gets or sets the nicknames.
        /// </summary>
        /// <value>
        /// The nicknames.
        /// </value>
        public List<string> Nicknames { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName { get; set; }
    }
}