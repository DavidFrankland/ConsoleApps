using System;
using ConfigTest;

namespace AzureKeyVault
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var keyVaultBaseUrl = ConfigHelper.GetSetting("AzureKeyVault_KeyVaultBaseUrl");
            var clientId = ConfigHelper.GetSetting("AzureKeyVault_ClientId");
            var clientSecret = ConfigHelper.GetSetting("AzureKeyVault_ClientSecret");

            var keyName = args.Length > 0 
                ? args[0] 
                : ConfigHelper.GetSetting("AzureKeyVault_KeyName");

            var pm = new PasswordManager(keyVaultBaseUrl, clientId, clientSecret);
            var password = pm.GetPassword(keyName).Result;
            Console.WriteLine(password);
        }
    }
}
