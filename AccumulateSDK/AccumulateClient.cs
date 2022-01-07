using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK
{
    /// <summary>Class <c>AccumulateClient</c> initialized this SDK.
    /// </summary>
    ///
    public class AccumulateClient
    {

        internal static string URL { get; set; }

        private AccumulateClient() { }

        /// <summary>Method <c>Init</c> initialized the client with the specified URL.</summary>
        /// <param name="url">Endpoint URL (if not specified, Localhost endpoint by default)</param>
        public static void Init(string url = Constant.LOCALHOST_ENDPOINT_V1)
        {
            if(string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }
            URL = url;
        }

        /// <summary>Method <c>Init</c> initialized the client with the specified URL.</summary>
        /// <param name="node">URL node (e.g. "https://testnet.accumulatenetwork.io")</param>
        /// <param name="port">Port (e.g. 85)</param>
        /// <param name="endpoint">Endpoint (e.g. /v1)</param>
        public static void Init(string node, int? port, string endpoint)
        {
            string port_value = string.Empty;
            if (string.IsNullOrWhiteSpace(node))
            {
                throw new ArgumentNullException("node");
            }
            if (port.HasValue && port.Value <= 0)
            {
                throw new ArgumentNullException("port");
            }
            else
            {
                if(port.HasValue)
                {
                    port_value = ":" + port;
                }
            }
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ArgumentNullException("endpoint");
            }
            URL = node+ port_value + endpoint;
        }

    }
}
