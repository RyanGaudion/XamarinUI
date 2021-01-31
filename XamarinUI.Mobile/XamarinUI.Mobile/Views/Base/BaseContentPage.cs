using XamarinUI.Mobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinUI.Mobile.Views.Base
{
    public class BaseContentPage : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var bindingContext = BindingContext as BaseViewModel;
            if (bindingContext != null)
                await bindingContext.OnAppearingAsync();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            var bindingContext = BindingContext as BaseViewModel;
            if (bindingContext != null)
                await bindingContext.OnDisappearingAsync();
        }
    }
}
