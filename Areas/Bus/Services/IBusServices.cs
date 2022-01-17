using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Bus.Services
{
    public interface IBusServices
    {
        //les fonctions qu'on va etre les definer dans le bus busService:
        Task<IEnumerable<Models.Bus>> GetAllBuses();
        Task<Models.Bus> EditBus(int id, Models.Bus bus);
        Task<Models.Bus> Create(Models.Bus bus);
        Task<Models.Bus> DeleteBus(int id);
    }
}
