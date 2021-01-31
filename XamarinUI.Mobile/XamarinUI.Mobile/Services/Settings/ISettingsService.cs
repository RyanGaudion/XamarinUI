using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinUI.Mobile.Services.Settings
{
    public interface ISettingsService
    {
        bool UseMocks { get; set; }
        string AuthedUsername { get; set; }

        bool GetValueOrDefault(string key, bool defaultValue);
        string GetValueOrDefault(string key, string defaultValue);
        Task AddOrUpdateValue(string key, bool value);
        Task AddOrUpdateValue(string key, string value);
    }
}
