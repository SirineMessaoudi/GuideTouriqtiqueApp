using GuideTouristiqueApp.Areas.ServiceTouristique.Services;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.ServiceTouristique.Services
{
    public class ServiceTouristiqueService : IServiceTouristiqueServices
    {
        private readonly ApplicationDbContext _db;
        public ServiceTouristiqueService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.ServiceTouristique> Create(Models.ServiceTouristique service)
        {
            _db.services.Add(service);
            await _db.SaveChangesAsync();
            return service;
        }

        public async Task<Models.ServiceTouristique> EditService(int id, Models.ServiceTouristique service)
        {
            //recuperer une par son id : 
            var serviceInDb = _db.services.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(service);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le service update 
            return service;
        }

        public async Task<IEnumerable<Models.ServiceTouristique>> GetAllServices()
        {
            // retourner une liste des services : 
            return await _db.services.ToListAsync();
        }
        public async Task<Models.ServiceTouristique> DeleteService(int id)
        {
            var serviceInDb = await _db.services.FindAsync(id);
            _db.Remove(serviceInDb);
            await _db.SaveChangesAsync();
            return serviceInDb;

        }


     
    }
}
