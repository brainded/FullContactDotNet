using FullContactDotNet.Entities;

namespace FullContactDotNet
{
    public interface IFullContactEmailApi
    {
        /// <summary>
        /// Detects the disposable email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        DisposableEmailResponse DetectDisposableEmail(string emailAddress);
    }
}
