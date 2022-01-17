using GuideTouristiqueApp.Areas.SiteTouristique.Sites;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.SiteTouristique.Services
{
    public class SiteService : ISiteServices
    {
        private readonly ApplicationDbContext _db;
        public SiteService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.SiteTouristique> Create(Models.SiteTouristique site)
        {
            _db.sites.Add(site);
            await _db.SaveChangesAsync();
            return site;
        }

        public async Task<Models.SiteTouristique> EditSite(int id, Models.SiteTouristique site)
        {
            //recuperer une par son id : 
            var SiteInDb = _db.sites.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(site);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le site update 
            return site;
        }

        public async Task<IEnumerable<Models.SiteTouristique>> GetAllSites()
        {
            // retourner une liste des sites : 
            return await _db.sites.ToListAsync();
        }
        public async Task<Models.SiteTouristique> DeleteSite(int id)
        {
            var SiteInDb = await _db.sites.FindAsync(id);
            _db.Remove(SiteInDb);
            await _db.SaveChangesAsync();
            return SiteInDb;

        }

    }
}
