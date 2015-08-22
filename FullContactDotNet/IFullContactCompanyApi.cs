using FullContactDotNet.Company;

namespace FullContactDotNet
{
    public interface IFullContactCompanyApi
    {
        /// <summary>
        /// Lookups the company by domain.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <param name="webhookUrl">The webhook URL.</param>
        /// <returns></returns>
        CompanyResponse LookupCompanyByDomain(string domain, string webhookUrl = null);
    }
}
