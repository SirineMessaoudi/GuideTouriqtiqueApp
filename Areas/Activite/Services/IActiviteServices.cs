using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Activite.Services
{
    public interface IActiviteServices
    {
        //les fonctions qu'on va etre les definer dans le Activite activiteService:
        Task<IEnumerable<Models.Activite>> GetAllActivites();
        Task<Models.Activite> EditActivite(int id, Models.Activite activite);
        Task<Models.Activite> Create(Models.Activite activite);
        Task<Models.Activite> DeleteActivite(int id);
    }
}
