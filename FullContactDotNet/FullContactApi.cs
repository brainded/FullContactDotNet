using RestSharp;
using System;

namespace FullContactDotNet
{
    public abstract class FullContactApi
    {
        /// <summary>
        /// The API base URL
        /// </summary>
        private const string ApiBaseUrl = "https://api.fullcontact.com/v2";

        /// <summary>
        /// The API key
        /// </summary>
        private string ApiKey;

        /// <summary>
        /// The FullContact client
        /// </summary>
        private RestClient FullContactClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactApi"/> class.
        /// </summary>
        public FullContactApi() : this(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactApi" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <exception cref="System.ArgumentNullException">An api key is required to communicate with Full Contact.</exception>
        public FullContactApi(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException("An api key is required to communicate with Full Contact.");
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets the FullContact client.
        /// </summary>
        /// <returns></returns>
        protected RestClient GetClient()
        {
            if (this.FullContactClient != null) return this.FullContactClient;
            
            this.FullContactClient = new RestClient(ApiBaseUrl);
            this.FullContactClient.AddDefaultParameter("apiKey", this.ApiKey);
            return this.FullContactClient;
        }

        /// <summary>
        /// Executes the specified FullContact request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        protected T Execute<T>(RestRequest request) where T : new()
        {
            var client = GetClient();
            var response = client.Execute<T>(request);

            if (response.ErrorException != null) throw new FullContactApiException(string.Format("FullContact responded with Status Code: {0}.", response.StatusCode), response.ErrorException);

            return response.Data;
        }
    }
}
