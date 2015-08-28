using FullContactDotNet.Company;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactCompanyApi : FullContactApi, IFullContactCompanyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactCompanyApi"/> class.
        /// </summary>
        public FullContactCompanyApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactCompanyApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactCompanyApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Lookups the company by domain.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <param name="webhookUrl">The webhook URL.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A domain is required to lookup a company.</exception>
        public CompanyResponse LookupCompanyByDomain(string domain, string webhookUrl = null)
        {
            if (string.IsNullOrEmpty(domain)) throw new ArgumentNullException("domain", "A domain is required to lookup a company.");

            var request = new RestRequest("/company/lookup.json", Method.GET);
            request.AddParameter("domain", domain);

            if (!string.IsNullOrWhiteSpace(webhookUrl))
            {
                request.AddParameter("webhookUrl", webhookUrl);
            }

            return Execute<CompanyResponse>(request);
        }
    }
}
