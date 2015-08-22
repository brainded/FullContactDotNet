using FullContactDotNet.Account;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactAccountApi : FullContactApi, IFullContactAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactAccountApi"/> class.
        /// </summary>
        public FullContactAccountApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactAccountApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactAccountApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Gets the account stats.
        /// </summary>
        /// <param name="period">The period.</param>
        /// <returns></returns>
        public AccountStatsResponse GetAccountStats(DateTime? period = null)
        {
            var request = new RestRequest("/stats.json", Method.GET);

            if (period.HasValue)
            {
                string formattedPeriod = period.Value.ToString("yyyy-MM");
                request.AddParameter("period", formattedPeriod);
            }

            return Execute<AccountStatsResponse>(request);
        }
    }
}
