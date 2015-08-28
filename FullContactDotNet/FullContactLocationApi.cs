using FullContactDotNet.Location;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactLocationApi : FullContactApi, IFullContactLocationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactLocationApi"/> class.
        /// </summary>
        public FullContactLocationApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactLocationApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactLocationApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Gets the normalized location.
        /// </summary>
        /// <param name="place">The place.</param>
        /// <param name="includeZeroPopulation">The include zero population.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">An email address is required to lookup a person by email.</exception>
        public NormalizedLocationResponse GetNormalizedLocation(string place, bool? includeZeroPopulation = null, Casing? casing = null)
        {
            if (string.IsNullOrWhiteSpace(place)) throw new ArgumentNullException("place", "A place is required to get a normalized location.");

            var request = GetLocationRequest("locationNormalizer", includeZeroPopulation, casing);
            request.AddParameter("place", place);
            return Execute<NormalizedLocationResponse>(request);
        }

        /// <summary>
        /// Gets the enriched location.
        /// </summary>
        /// <param name="place">The place.</param>
        /// <param name="includeZeroPopulation">The include zero population.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A place is required to get a normalized location.</exception>
        public EnrichedLocationResponse GetEnrichedLocation(string place, bool? includeZeroPopulation = null, Casing? casing = null)
        {
            if (string.IsNullOrWhiteSpace(place)) throw new ArgumentNullException("place", "A place is required to get a enriched location.");

            var request = GetLocationRequest("locationEnrichment", includeZeroPopulation, casing);
            request.AddParameter("place", place);
            return Execute<EnrichedLocationResponse>(request);
        }

        /// <summary>
        /// Gets the location request.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <param name="includeZeroPopulation">The include zero population.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        private RestRequest GetLocationRequest(string resource, bool? includeZeroPopulation = null, Casing? casing = null)
        {
            var request = new RestRequest(string.Format("/address/{0}.json", resource), Method.GET);

            if (includeZeroPopulation.HasValue)
            {
                request.AddParameter("includeZeroPopulation", includeZeroPopulation.Value);
            }

            if (casing.HasValue)
            {
                request.AddParameter("casing", casing.Value);
            }

            return request;
        }
    }
}
