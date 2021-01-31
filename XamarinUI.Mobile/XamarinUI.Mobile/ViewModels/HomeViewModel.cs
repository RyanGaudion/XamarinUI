using XamarinUI.Mobile.Services.Navigation;
using XamarinUI.Mobile.Services.Settings;
using XamarinUI.Mobile.Services.User;
using XamarinUI.Mobile.ViewModels.Base;
using XamarinUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinUI.Mobile.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        INavigationService navigationService;
        public IUserService userService { get; set; }
        public HomeViewModel(INavigationService _navigationService, IUserService _userService)
        {
            navigationService = _navigationService;
            userService = _userService;
            Commands.Add("ChangeName", new Command(() => ChangeName()));
        }

        public override Task OnAppearingAsync()
        {
            return base.OnAppearingAsync();
        }

        #region vmProperties
        

        #endregion


        #region vmMethods
        void ChangeName()
        {
            userService.LoggedOnUser.Username = "Hello World";
        }

        #endregion
    }
}
