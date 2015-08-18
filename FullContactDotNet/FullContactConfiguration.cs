using System.Configuration;

namespace FullContactDotNet
{
    public class FullContactConfiguration
    {
        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public static string ApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["FullContactApiKey"];
            }
        }
    }
}
