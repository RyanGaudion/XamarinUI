using XamarinUI.Mobile.Services.Navigation;
using XamarinUI.Mobile.Services.Settings;
using XamarinUI.Mobile.Services.User;
using Singularity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using XamarinUI.Shared.DataAccess.Interfaces;
using XamarinUI.Shared.DataAccess.Repositories.Mock;

namespace XamarinUI.Mobile.ViewModels.Base
{
    public static class ViewModelLocator
    {
        private static Container _contianer;

        public static readonly BindableProperty AutoWireViewModelProperty =
            BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator), default(bool), propertyChanged: OnAutoWireViewModelChanged);
        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ViewModelLocator.AutoWireViewModelProperty);
        }
        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(ViewModelLocator.AutoWireViewModelProperty, value);
        }

        static ViewModelLocator()
        {
            _contianer = new Container(builder =>
            {
                //Repositories
                builder.Register<IDiscoveryRepository, DiscoveryRepository>();

                //ViewModels
                builder.Register<HomeViewModel>();

                //Services
                builder.Register<INavigationService, NavigationService>(c => c.With(Lifetimes.PerContainer));
                builder.Register<ISettingsService, SettingsService>(c => c.With(Lifetimes.PerContainer));
                builder.Register<IUserService, UserService>(c => c.With(Lifetimes.PerContainer));
            });
        }

        public static T Resolve<T>() where T : class
        {
            return _contianer.GetInstance<T>();
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as Element;
            if(view == null)
            {
                return;
            }

            var viewType = view.GetType();
            var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
            var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
            var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}Model, {1}", viewName, viewAssemblyName);

            var viewModelType = Type.GetType(viewModelName);
            if(viewModelType == null)
            {
                return;
            }
            var viewModel = _contianer.GetInstance(viewModelType);
            view.BindingContext = viewModel;
        }
    }
}

