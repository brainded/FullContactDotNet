using FullContactDotNet.Entities;

namespace FullContactDotNet
{
    public interface IFullContactApi
    {
        /// <summary>
        /// Lookups the by email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        Person LookupByEmail(string emailAddress);

        /// <summary>
        /// Lookups the by phone.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        Person LookupByPhone(string phoneNumber, string countryCode = null);

        /// <summary>
        /// Lookups the by twitter.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <returns></returns>
        Person LookupByTwitter(string twitterUsername);

        /// <summary>
        /// Lookups the by facebook.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <returns></returns>
        Person LookupByFacebook(string facebookUsername);
    }
}
