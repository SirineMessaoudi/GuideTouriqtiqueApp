using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Transport.Services
{
    public interface ITransportServices
    {
        //les fonctions qu'on va etre les definer dans le Transport transportService:
        Task<IEnumerable<Models.Transport>> GetAllTransports();
        Task<Models.Transport> EditTransport(int id, Models.Transport transport);
        Task<Models.Transport> Create(Models.Transport transport);
        Task<Models.Transport> DeleteTransport(int id);
    }
}
