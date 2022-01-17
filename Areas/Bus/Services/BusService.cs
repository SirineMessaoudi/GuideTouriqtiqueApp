using GuideTouristiqueApp.Areas.Bus.Services;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Bus.Services
{
    public class BusService : IBusServices
    {
        private readonly ApplicationDbContext _db;
        public BusService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Bus> Create(Models.Bus bus)
        {
            _db.buses.Add(bus);
            await _db.SaveChangesAsync();
            return bus;
        }

        public async Task<Models.Bus> EditBus(int id, Models.Bus bus)
        {
            //recuperer une par son id : 
            var busInDb = _db.buses.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(bus);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le bus update 
            return bus;
        }

        public async Task<IEnumerable<Models.Bus>> GetAllBuses()
        {
            // retourner une liste des buses : 
            return await _db.buses.ToListAsync();
        }
        public async Task<Models.Bus> DeleteBus(int id)
        {
            var busInDb = await _db.buses.FindAsync(id);
            _db.Remove(busInDb);
            await _db.SaveChangesAsync();
            return busInDb;

        }


     
    }
}
