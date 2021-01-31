using XamarinUI.Mobile.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : BaseContentPage
    {
        private double headingOpacity = 0.6;
        public HomeView()
        {
            InitializeComponent();
            showHeading(1);
        }

        private void Headings1_Tapped(object sender, EventArgs e)
        {
            showHeading(1);
        }
        private void Headings2_Tapped(object sender, EventArgs e)
        {
            showHeading(2);
        }
        private void Headings3_Tapped(object sender, EventArgs e)
        {
            showHeading(3);
        }
        private void Headings4_Tapped(object sender, EventArgs e)
        {
            showHeading(4);
        }

        #region reuseable
        private void showHeading(int headingID)
        {
            hideAllHeadings();
            if(headingID == 1)
            {
                HeadingsUnderline1.IsVisible = true;
                Headings1.Opacity = 1;
            }
            else if (headingID == 2)
            {
                HeadingsUnderline2.IsVisible = true;
                Headings2.Opacity = 1;
            }
            else if (headingID == 3)
            {
                HeadingsUnderline3.IsVisible = true;
                Headings3.Opacity = 1;
            }
            else if (headingID == 4)
            {
                HeadingsUnderline4.IsVisible = true;
                Headings4.Opacity = 1;
            }
        }

        private void hideAllHeadings()
        {
            HeadingsUnderline1.IsVisible = false;
            Headings1.Opacity = headingOpacity;
            HeadingsUnderline2.IsVisible = false;
            Headings2.Opacity = headingOpacity;
            HeadingsUnderline3.IsVisible = false;
            Headings3.Opacity = headingOpacity;
            HeadingsUnderline4.IsVisible = false;
            Headings4.Opacity = headingOpacity;
        }
        #endregion
    }
}