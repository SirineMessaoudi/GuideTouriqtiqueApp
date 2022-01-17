using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.ServiceTouristique.Services
{
    public interface IServiceTouristiqueServices
    {
        //les fonctions qu'on va etre les definer dans le service ServiceService:
        Task<IEnumerable<Models.ServiceTouristique>> GetAllServices();
        Task<Models.ServiceTouristique> EditService(int id, Models.ServiceTouristique service);
        Task<Models.ServiceTouristique> Create(Models.ServiceTouristique service);
        Task<Models.ServiceTouristique> DeleteService(int id);
    }
}
