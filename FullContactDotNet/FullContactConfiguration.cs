using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
