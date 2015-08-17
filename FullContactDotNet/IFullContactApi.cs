using FullContactDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
