using FullContactDotNet.Name;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactNameApi : FullContactApi, IFullContactNameApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactNameApi"/> class.
        /// </summary>
        public FullContactNameApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactNameApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactNameApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Gets the name normalization.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A name is required to get a name normalization.</exception>
        public NameResponse GetNameNormalization(string name, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name", "A name is required to get a name normalization.");

            var request = new RestRequest("/name/normalizer.json", Method.GET);
            request.AddParameter("q", name);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return Execute<NameResponse>(request);
        }

        /// <summary>
        /// Gets the name deduction by email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A email address is required to get a name deduction.</exception>
        public NameResponse GetNameDeductionByEmail(string emailAddress, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("emailAddress", "An email address is required to get a name deduction.");

            var request = GetNameDeductionRequest(casing);
            request.AddParameter("email", emailAddress);
            return Execute<NameResponse>(request);
        }

        /// <summary>
        /// Gets the name deduction by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A username is required to get a name deduction.</exception>
        public NameResponse GetNameDeductionByUsername(string username, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(username)) throw new ArgumentNullException("username", "A username is required to get a name deduction.");

            var request = GetNameDeductionRequest(casing);
            request.AddParameter("username", username);
            return Execute<NameResponse>(request);
        }

        /// <summary>
        /// Gets the name similarity.
        /// </summary>
        /// <param name="nameA">The name a.</param>
        /// <param name="nameB">The name b.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// A name is required to get a name similarity.
        /// or
        /// A name to compare to is required to get a name similarity.
        /// </exception>
        public NameSimilarityResponse GetNameSimilarity(string nameA, string nameB, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(nameA)) throw new ArgumentNullException("nameA", "A name is required to get a name similarity.");
            if (string.IsNullOrEmpty(nameB)) throw new ArgumentNullException("nameB", "A name to compare to is required to get a name similarity.");

            var request = new RestRequest("/name/similarity.json", Method.GET);
            request.AddParameter("q1", nameA);
            request.AddParameter("q2", nameB);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return Execute<NameSimilarityResponse>(request);
        }

        /// <summary>
        /// Gets the stats of a name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A name is required to get name stats.</exception>
        public NameStatsResponse GetNameStatsByName(string name, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name", "A name is required to get name stats.");

            var request = GetNameStatsRequest(casing);
            request.AddParameter("name", name);

            return Execute<NameStatsResponse>(request);
        }

        /// <summary>
        /// Gets the stats of a given and family name.
        /// </summary>
        /// <param name="givenName">The given name.</param>
        /// <param name="familyName">The family name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// A given name is required to get name stats.
        /// or
        /// A family name is required to get name stats.
        /// </exception>
        public NameStatsResponse GetNameStatsByName(string givenName, string familyName, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(givenName)) throw new ArgumentNullException("givenName", "A given name is required to get name stats.");
            if (string.IsNullOrEmpty(familyName)) throw new ArgumentNullException("familyName", "A family name is required to get name stats.");

            var request = GetNameStatsRequest(casing);
            request.AddParameter("givenName", givenName);
            request.AddParameter("familyName", familyName);

            return Execute<NameStatsResponse>(request);
        }

        /// <summary>
        /// Gets the stats of a given name.
        /// </summary>
        /// <param name="givenName">The given name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A given name is required to get name stats.</exception>
        public NameStatsResponse GetNameStatsByGivenName(string givenName, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(givenName)) throw new ArgumentNullException("givenName", "A given name is required to get name stats.");

            var request = GetNameStatsRequest(casing);
            request.AddParameter("givenName", givenName);

            return Execute<NameStatsResponse>(request);
        }

        /// <summary>
        /// Gets the stats of a family name.
        /// </summary>
        /// <param name="familyName">The family name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A family name is required to get name stats.</exception>
        public NameStatsResponse GetNameStatsByFamilyName(string familyName, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(familyName)) throw new ArgumentNullException("familyName", "A family name is required to get name stats.");

            var request = GetNameStatsRequest(casing);
            request.AddParameter("familyName", familyName);

            return Execute<NameStatsResponse>(request);
        }

        /// <summary>
        /// Gets the parsed name for a given ambiguous name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A name is required to get a parsed name.</exception>
        public NameParsedResponse GetNameParsed(string name, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name", "A name is required to get a parsed name.");

            var request = new RestRequest("/name/parser.json", Method.GET);
            request.AddParameter("q", name);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return Execute<NameParsedResponse>(request);
        }

        /// <summary>
        /// Gets the name deduction request.
        /// </summary>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        private RestRequest GetNameDeductionRequest(Casing? casing = null)
        {
            return GetNameRequest("deducer");
        }

        /// <summary>
        /// Gets the name stats request.
        /// </summary>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        private RestRequest GetNameStatsRequest(Casing? casing = null)
        {
            return GetNameRequest("stats");
        }

        /// <summary>
        /// Gets the name request.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        private RestRequest GetNameRequest(string resource, Casing? casing = null)
        {
            var request = new RestRequest(string.Format("/name/{0}.json", resource), Method.GET);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return request;
        }
    }
}
