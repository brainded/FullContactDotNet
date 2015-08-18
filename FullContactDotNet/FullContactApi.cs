using FullContactDotNet.Entities;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactApi : IFullContactApi
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
        /// Lookup Person by email address.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A email address is required to lookup a person by email.</exception>
        public Person LookupPersonByEmail(string emailAddress, int? queue = null, string webhook = null)
        {
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("A email address is required to lookup a person by email.");

            var request = GetPersonRequest(queue, webhook);
            request.AddParameter("email", emailAddress);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A phone number is required to lookup a person by twitter.</exception>
        public Person LookupPersonByPhone(string phoneNumber, string countryCode = null, int? queue = null, string webhook = null)
        {
            if (string.IsNullOrEmpty(phoneNumber)) throw new ArgumentNullException("A phone number is required to lookup a person by twitter.");

            //TODO: investigate if the phone number needs to be formatted in a particular way

            var request = GetPersonRequest(queue, webhook);
            request.AddParameter("phone", phoneNumber);

            if (!string.IsNullOrWhiteSpace(countryCode))
            {
                request.AddParameter("countryCode", countryCode);
            }

            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by twitter username.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A twitter username is required to lookup a person by twitter.</exception>
        public Person LookupPersonByTwitter(string twitterUsername, int? queue = null, string webhook = null)
        {
            if (string.IsNullOrEmpty(twitterUsername)) throw new ArgumentNullException("A twitter username is required to lookup a person by twitter.");

            var request = GetPersonRequest(queue, webhook);
            request.AddParameter("twitter", twitterUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by facebook username.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A facebook username is required to lookup a person by facebook.</exception>
        public Person LookupPersonByFacebook(string facebookUsername, int? queue = null, string webhook = null)
        {
            if (string.IsNullOrEmpty(facebookUsername)) throw new ArgumentNullException("A facebook username is required to lookup a person by facebook.");

            var request = GetPersonRequest(queue, webhook);
            request.AddParameter("facebookUsername", facebookUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Gets the person request.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        private RestRequest GetPersonRequest(int? queue = null, string webhook = null)
        {
            var request = new RestRequest("/person.json", Method.GET);

            if (queue.HasValue)
            {
                request.AddParameter("queue", queue.Value);
            }

            if (!string.IsNullOrWhiteSpace(webhook))
            {
                request.AddParameter("webhook", webhook);
            }

            return request;
        }

        /// <summary>
        /// Gets the FullContact client.
        /// </summary>
        /// <returns></returns>
        private RestClient GetClient()
        {
            if (FullContactClient != null) return FullContactClient;
            FullContactClient = new RestClient(ApiBaseUrl);
            FullContactClient.AddDefaultParameter("apiKey", this.ApiKey);
            return FullContactClient;
        }

        /// <summary>
        /// Executes the specified FullContact request.
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
