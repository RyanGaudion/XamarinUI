using XamarinUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinUI.Shared.Models.Person;

namespace XamarinUI.Mobile.Services.User
{
    public interface IUserService
    {
        Person LoggedOnUser { get; set; }
        bool Login(string username, string password);
        void Logout();
    }
}
