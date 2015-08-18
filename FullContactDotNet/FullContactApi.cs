using FullContactDotNet.Entities;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactApi : IFullContactApi
    {
        private const string ApiBaseUrl = "https://api.fullcontact.com/v2";
        private string ApiKey;
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
        /// Lookups the by email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A email address is required to lookup a person by email.</exception>
        public Person LookupByEmail(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("A email address is required to lookup a person by email.");

            var request = new RestRequest("/person.json", Method.GET);
            request.AddParameter("email", emailAddress);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookups the by twitter.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A twitter username is required to lookup a person by twitter.</exception>
        public Person LookupByTwitter(string twitterUsername)
        {
            if (string.IsNullOrEmpty(twitterUsername)) throw new ArgumentNullException("A twitter username is required to lookup a person by twitter.");

            var request = new RestRequest("/person.json", Method.GET);
            request.AddParameter("twitter", twitterUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookups the by facebook.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A facebook username is required to lookup a person by facebook.</exception>
        public Person LookupByFacebook(string facebookUsername)
        {
            if (string.IsNullOrEmpty(facebookUsername)) throw new ArgumentNullException("A facebook username is required to lookup a person by facebook.");

            var request = new RestRequest("/person.json", Method.GET);
            request.AddParameter("facebookUsername", facebookUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <returns></returns>
        private RestClient GetClient()
        {
            if (FullContactClient != null) return FullContactClient;

            if (string.IsNullOrEmpty(this.ApiKey)) throw new ApplicationException("An api key is required to communicate with Full Contact.");

            FullContactClient = new RestClient(ApiBaseUrl);
            FullContactClient.AddDefaultParameter("apiKey", this.ApiKey);
            return FullContactClient;
        }

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private T Execute<T>(RestRequest request) where T : new()
        {
            var client = GetClient();
            var response = client.Execute<T>(request);

            if (response.ErrorException != null) throw new FullContactApiException(string.Format("FullContact responded with Status Code: {0}.", response.StatusCode), response.ErrorException);

            return response.Data;
        }
    }
}
