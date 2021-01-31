using XamarinUI.Shared.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinUI.Shared.Models
{
    public class Person : ObservableObject
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

    }
}
