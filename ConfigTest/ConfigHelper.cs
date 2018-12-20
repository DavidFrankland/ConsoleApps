using System;
using System.Configuration;

namespace ConfigTest
{
    public static class ConfigHelper
    {
        public static string GetSetting(string key)
        {
            var configValue = ConfigurationManager.AppSettings[key];
            if (configValue == null) throw new Exception($"Config setting not found: '{key}'");
            return configValue;
        }

        public static T GetSetting<T>(string key) where T : IConvertible
        {
            return ConvertValue<T>(key, GetSetting(key));
        }

        public static T GetSetting<T>(string key, T defaultValue) where T : IConvertible
        {
            var configValue = ConfigurationManager.AppSettings[key];
            return configValue == null ? defaultValue : ConvertValue<T>(key, configValue);
        }

        private static T ConvertValue<T>(string key, string value) 
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception ex)
            {
                var errorMessage = $"Invalid {typeof(T)} config setting: '{key}' value: '{value}'";
                throw new Exception(errorMessage, ex);
            }
        }
    }
}
