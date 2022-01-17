using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.SiteTouristique.Sites
{
    public interface ISiteServices
    {
        //les fonctions qu'on va etre les definer dans le Site SiteSite:
        Task<IEnumerable<Models.SiteTouristique>> GetAllSites();
        Task<Models.SiteTouristique> EditSite(int id, Models.SiteTouristique site);
        Task<Models.SiteTouristique> Create(Models.SiteTouristique site);
        Task<Models.SiteTouristique> DeleteSite(int id);
    }
}
