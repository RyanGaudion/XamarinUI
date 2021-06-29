using System.Collections.Generic;
using XamarinUI.Shared.Models.Music;
using XamarinUI.Shared.Models.Person;

namespace XamarinUI.Shared.DataAccess.Interfaces
{
    public interface IDiscoveryRepository
    {
        List<DiscoverHeading> GetDiscoveryHeaders(Person user);
    }
}