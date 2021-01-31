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
using XamarinUI.Mobile.Models;

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
            discoverHeadings = new List<DiscoverHeading>();
            Commands.Add("ChangeName", new Command(() => ChangeName()));
        }

        public override Task OnAppearingAsync()
        {
            DiscoverHeadings.Clear();
            DiscoverHeadings.Add(new DiscoverHeading() { Text = "DAILY MIX", ImageURL = "https://www.musicweek.com/cimages/6f29a0176e1bc5ca28aa893dd1c1987e.jpg", StartColor = Color.FromHex("000000"), EndColor = Color.FromHex("104756"), Scale = 1.1 }) ;
            DiscoverHeadings.Add(new DiscoverHeading() { Text = "UP & COMING", ImageURL = "https://www.newreleasetoday.com/thum_creater/phpThumb.php?src=../images/artist_images/img_2360.jpg&w=300&h=360&zc=1", StartColor = Color.FromHex("000000"), EndColor = Color.FromHex("d4eff7"), Scale = 1.1 }) ;
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
