using FullContactDotNet.Entities;

namespace FullContactDotNet
{
    public interface IFullContactApi
    {
        /// <summary>
        /// Lookup Person by email address.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        Person LookupPersonByEmail(string emailAddress);

        /// <summary>
        /// Lookup Person by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        Person LookupPersonByPhone(string phoneNumber, string countryCode = null);

        /// <summary>
        /// Lookup Person by twitter username.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <returns></returns>
        Person LookupPersonByTwitter(string twitterUsername);

        /// <summary>
        /// Lookup Person by facebook username.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <returns></returns>
        Person LookupPersonByFacebook(string facebookUsername);
    }
}
