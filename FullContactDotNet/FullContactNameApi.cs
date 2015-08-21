using FullContactDotNet.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("A name is required to get a name normalization.");

            var request = new RestRequest("/name/normalizer.json", Method.GET);
            request.AddParameter("name", name);

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
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("An email address is required to get a name deduction.");

            var request = GetNameDeduction(casing);
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
            if (string.IsNullOrEmpty(username)) throw new ArgumentNullException("A username is required to get a name deduction.");

            var request = GetNameDeduction(casing);
            request.AddParameter("username", username);
            return Execute<NameResponse>(request);
        }

        /// <summary>
        /// Gets the name deduction.
        /// </summary>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        private RestRequest GetNameDeduction(Casing? casing = null)
        {
            var request = new RestRequest("/name/deducer.json", Method.GET);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return request;
        }
    }
}
