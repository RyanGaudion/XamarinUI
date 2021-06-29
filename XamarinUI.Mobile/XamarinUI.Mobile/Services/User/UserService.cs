using XamarinUI.Mobile.Services.Settings;
using XamarinUI.Mobile.ViewModels.Base;
using XamarinUI.Shared.Models;
using XamarinUI.Shared.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinUI.Shared.Models.Person;

namespace XamarinUI.Mobile.Services.User
{
    public class UserService :  IUserService
    {
        ISettingsService settingsService;
        public UserService(ISettingsService _settingsService)
        {
            settingsService = _settingsService;
        }

        public Person LoggedOnUser { get; set;}

        public bool Login(string usernameString, string passwordString)
        {
            settingsService.AuthedUsername = usernameString;
            LoggedOnUser = new Person() { Username = usernameString };
            return true;
        }

        public void Logout()
        {
            settingsService.AuthedUsername = string.Empty;
        }
    }
}
