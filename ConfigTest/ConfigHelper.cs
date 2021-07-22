﻿using System;
using System.Configuration;

namespace ConfigTest
{
    public static class ConfigHelper
    {
        /// <summary>
        /// Gets value from config file.
        /// </summary>
        /// <param name="key">The key of the desired config value.</param>
        /// <returns>String value if the setting exists, null otherwise.</returns>
        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Gets value from config file.
        /// </summary>
        /// <typeparam name="T">The desired type of the returned value.</typeparam>
        /// <param name="key">The key of the desired config value.</param>
        /// <returns>A value of type <typeparamref name="T"/> if the setting exists.</returns>
        /// <exception cref="Exception">description</exception>
        public static T GetSetting<T>(string key) where T : IConvertible
        {
            var configValue = ConfigurationManager.AppSettings[key];
            return configValue != null ? ConvertValue<T>(key, configValue) : throw new Exception($"Config setting not found: '{key}'");
        }

        /// <summary>
        /// Gets value from config file.
        /// </summary>
        /// <typeparam name="T">The desired type of the returned value.</typeparam>
        /// <param name="key">The key of the desired config value.</param>
        /// <param name="defaultValue">The value to return if the setting does not exist.</param>
        /// <returns>
        ///     A value of type <typeparamref name="T"/> if the setting exists and can be converted into a <typeparamref name="T"/>,
        ///     <paramref name="defaultValue"/> if it doesn't exist or can't be converted.
        /// </returns> 
        public static T GetSetting<T>(string key, T defaultValue) where T : IConvertible
        {
            var configValue = ConfigurationManager.AppSettings[key];
            return configValue != null ? ConvertValue<T>(key, configValue) : defaultValue;
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
