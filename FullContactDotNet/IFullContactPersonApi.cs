using FullContactDotNet.Person;

namespace FullContactDotNet
{
    public interface IFullContactPersonApi
    {
        /// <summary>
        /// Lookup Person by email address.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        PersonResponse LookupPersonByEmail(string emailAddress, int? queue = null, string webhookUrl = null);

        /// <summary>
        /// Lookup Person by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        PersonResponse LookupPersonByPhone(string phoneNumber, string countryCode = null, int? queue = null, string webhookUrl = null);

        /// <summary>
        /// Lookup Person by twitter username.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        PersonResponse LookupPersonByTwitter(string twitterUsername, int? queue = null, string webhookUrl = null);

        /// <summary>
        /// Lookup Person by facebook username.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        PersonResponse LookupPersonByFacebook(string facebookUsername, int? queue = null, string webhookUrl = null);
    }
}
