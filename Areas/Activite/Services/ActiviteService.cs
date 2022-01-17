using GuideTouristiqueApp.Areas.Activite.Services;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Activite.Services
{
    public class ActiviteService : IActiviteServices
    {
        private readonly ApplicationDbContext _db;
        public ActiviteService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Activite> Create(Models.Activite activite)
        {
            _db.activites.Add(activite);
            await _db.SaveChangesAsync();
            return activite;
        }

        public async Task<Models.Activite> EditActivite(int id, Models.Activite activite)
        {
            //recuperer une par son id : 
            var ActiviteInDb = _db.activites.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(activite);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le Activite update 
            return activite;
        }

        public async Task<IEnumerable<Models.Activite>> GetAllActivites()
        {
            // retourner une liste des activites : 
            return await _db.activites.ToListAsync();
        }
        public async Task<Models.Activite> DeleteActivite(int id)
        {
            var ActiviteInDb = await _db.activites.FindAsync(id);
            _db.Remove(ActiviteInDb);
            await _db.SaveChangesAsync();
            return ActiviteInDb;

        }


     
    }
}
