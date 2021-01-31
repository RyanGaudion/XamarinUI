using XamarinUI.Mobile.Services.Navigation;
using XamarinUI.Mobile.ViewModels.Base;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            App.Current.UserAppTheme = OSAppTheme.Light;
            InitializeComponent();
            App.Current.UserAppTheme = OSAppTheme.Light;
            if (Device.RuntimePlatform == Device.UWP)
                InitNavigation();
        }

        private Task InitNavigation()
        {
            INavigationService navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
        protected override void OnStart()
        {
            if (Device.RuntimePlatform != Device.UWP)
                InitNavigation();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
