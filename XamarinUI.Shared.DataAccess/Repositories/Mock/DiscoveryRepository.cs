using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUI.Shared.DataAccess.Interfaces;
using XamarinUI.Shared.Models.Music;
using XamarinUI.Shared.Models.Person;

namespace XamarinUI.Shared.DataAccess.Repositories.Mock
{
    public class DiscoveryRepository : IDiscoveryRepository
    {
        public List<DiscoverHeading> GetDiscoveryHeaders(Person user)
        {
            List<DiscoverHeading> DiscoverHeadings = new List<DiscoverHeading>();
            DiscoverHeadings.Add(new DiscoverHeading() { Text = "DAILY MIX", ImageURL = "https://www.musicweek.com/cimages/6f29a0176e1bc5ca28aa893dd1c1987e.jpg", StartColor = Color.FromHex("000000"), EndColor = Color.FromHex("104756"), Scale = 1.1 });
            DiscoverHeadings.Add(new DiscoverHeading() { Text = "UP & COMING", ImageURL = "https://www.newreleasetoday.com/thum_creater/phpThumb.php?src=../images/artist_images/img_2360.jpg&w=300&h=360&zc=1", StartColor = Color.FromHex("000000"), EndColor = Color.FromHex("d4eff7"), Scale = 1.1 });
            return DiscoverHeadings;
        }
    }
}
