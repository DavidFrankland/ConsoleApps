using System;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace AzureKeyVault
{
    public class PasswordManager
    {
        private readonly string _keyVaultBaseUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public PasswordManager(string keyVaultBaseUrl, string clientId, string clientSecret)
        {
            _keyVaultBaseUrl = keyVaultBaseUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<string> GetPassword(string keyName)
        {
            using (var kv = new KeyVaultClient(GetToken))
            {
                var result = await kv.GetSecretAsync($"{_keyVaultBaseUrl}/secrets/{keyName}");

                if (result == null)
                    throw new InvalidOperationException($"Failed to obtain the secret from Azure for '{keyName}'");

                return result.Value;
            }
        }

        private async Task<string> GetToken(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            var clientCred = new ClientCredential(_clientId, _clientSecret);
            var result = await authContext.AcquireTokenAsync(resource, clientCred);

            if (result == null)
                throw new InvalidOperationException("Failed to obtain the JWT token");

            return result.AccessToken;
        }
    }
}