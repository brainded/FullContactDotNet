using FullContactDotNet.Entities;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactEmailApi : FullContactApi, IFullContactEmailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactEmailApi"/> class.
        /// </summary>
        public FullContactEmailApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactEmailApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactEmailApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Detects the disposable email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A email address is required to lookup a person by email.</exception>
        public DisposableEmailResponse DetectDisposableEmail(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("An email address is required to lookup a person by email.");

            var request = new RestRequest("/email.json", Method.GET);
            request.AddParameter("email", emailAddress);
            return Execute<DisposableEmailResponse>(request);
        }
    }
}
