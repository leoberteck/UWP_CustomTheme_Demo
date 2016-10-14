using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DynamicResourceTest
{
    public static class Helper
    {
        public static void SetSettingKey(string Key, string Value)
        {
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings.Values;
            if (!settings.ContainsKey(Key))
            {
                settings.Add(Key, Value);
            }
            else
            {
                settings[Key] = Value;
            }

        }

        public static void SetResourceKey(string Key, string Value)
        {
            var resources = Application.Current.Resources;
            if (!resources.ContainsKey(Key))
            {
                resources.Add(Key, Value);
            }
            else
            {
                resources[Key] = Value;
            }
        }

        public static string GetSettings(string Key)
        {
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings.Values;
            if (settings.ContainsKey(Key))
            {
                return settings[Key].ToString();
            }
            else
            {
                return "Red";
            }
        }
    }
}
