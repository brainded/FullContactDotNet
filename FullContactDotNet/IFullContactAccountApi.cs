using FullContactDotNet.Account;
using System;

namespace FullContactDotNet
{
    public interface IFullContactAccountApi
    {
        /// <summary>
        /// Gets the account stats.
        /// </summary>
        /// <param name="period">The period.</param>
        /// <returns></returns>
        AccountStatsResponse GetAccountStats(DateTime? period = null);
    }
}
