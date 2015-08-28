using FullContactDotNet.CardReader;
using FullContactDotNet.Shared;

namespace FullContactDotNet
{
    public interface IFullContactCardReaderApi
    {
        /// <summary>
        /// Uploads the card.
        /// </summary>
        /// <param name="frontBase64Encoded">The front base64 encoded.</param>
        /// <param name="backBase64Encoded">The back base64 encoded.</param>
        /// <param name="webhookUrl">The webhook URL.</param>
        /// <param name="casing">The casing.</param>
        /// <param name="sandbox">The sandbox.</param>
        /// <returns></returns>
        CardReaderResponse UploadCard(
            string frontBase64Encoded,
            string backBase64Encoded,
            string webhookUrl,
            Casing? casing = null,
            SandboxMode? sandbox = null);

        /// <summary>
        /// Uploads the card.
        /// </summary>
        /// <param name="front">The front.</param>
        /// <param name="back">The back.</param>
        /// <param name="webhookUrl">The webhook URL.</param>
        /// <param name="casing">The casing.</param>
        /// <param name="sandbox">The sandbox.</param>
        /// <returns></returns>
        CardReaderResponse UploadCard(
            byte[] front,
            byte[] back,
            string webhookUrl,
            Casing? casing = null,
            SandboxMode? sandbox = null);
    }
}
