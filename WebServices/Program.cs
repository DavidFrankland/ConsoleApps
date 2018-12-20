using System;
using System.Collections.Generic;

namespace WebServices
{
    public static class Program
    {
        private static void Main()
        {
            //var eTradeGatewayClient = new eTradeGatewayService.eTradeGatewaySoapClient();
            //eTradeGatewayClient.ClientCredentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials;
            //eTradeGatewayClient.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            //var shapes = eTradeGatewayClient.GetShapes();

            var edlServiceClient = new EdlWebService.EdlWebServiceSoapClient();
            edlServiceClient.ClientCredentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials;
            edlServiceClient.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            short unitNumber = 1;
            var efa = true;

            var q = edlServiceClient.GetAllPnProfiles();

        }
    }
}
