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
        public NameNormalizationResponse GetNameNormalization(string name, Casing? casing = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("A name is required to get a name normalization.");

            var request = new RestRequest("/name/normalizer.json", Method.GET);
            request.AddParameter("name", name);

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return Execute<NameNormalizationResponse>(request);
        }
    }
}
