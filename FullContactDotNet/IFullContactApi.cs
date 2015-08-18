using FullContactDotNet.Entities;

namespace FullContactDotNet
{
    public interface IFullContactApi
    {
        /// <summary>
        /// Lookup Person by email address.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        Person LookupPersonByEmail(string emailAddress, int? queue = null, string webhook = null);

        /// <summary>
        /// Lookup Person by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        Person LookupPersonByPhone(string phoneNumber, string countryCode = null, int? queue = null, string webhook = null);

        /// <summary>
        /// Lookup Person by twitter username.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        Person LookupPersonByTwitter(string twitterUsername, int? queue = null, string webhook = null);

        /// <summary>
        /// Lookup Person by facebook username.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhook">The webhook.</param>
        /// <returns></returns>
        Person LookupPersonByFacebook(string facebookUsername, int? queue = null, string webhook = null);
    }
}
