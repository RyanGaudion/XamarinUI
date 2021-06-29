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
using XamarinUI.Shared.Models.Music;
using XamarinUI.Shared.DataAccess.Interfaces;

namespace XamarinUI.Mobile.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        INavigationService navigationService;
        IDiscoveryRepository discoveryRepository;
        public IUserService userService { get; set; }

        public HomeViewModel(INavigationService _navigationService, IUserService _userService, IDiscoveryRepository _discoveryRepository)
        {
            navigationService = _navigationService;
            userService = _userService;
            discoveryRepository = _discoveryRepository;
            discoverHeadings = new List<DiscoverHeading>();
            Commands.Add("ChangeName", new Command(() => ChangeName()));
        }

        public override Task OnAppearingAsync()
        {
            DiscoverHeadings = discoveryRepository.GetDiscoveryHeaders(userService.LoggedOnUser);
            return base.OnAppearingAsync();
        }

        #region vmProperties
        private List<DiscoverHeading> discoverHeadings;

        public List<DiscoverHeading> DiscoverHeadings
        {
            get { return discoverHeadings; }
            set { SetProperty(ref discoverHeadings, value); }
        }


        #endregion


        #region vmMethods
        void ChangeName()
        {
            userService.LoggedOnUser.Username = "Hello World";
        }

        #endregion
    }
}
