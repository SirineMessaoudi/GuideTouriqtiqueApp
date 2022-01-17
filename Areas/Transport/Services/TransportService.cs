using GuideTouristiqueApp.Areas.Transport.Services;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Transport.Services
{
    public class TransportService : ITransportServices
    {
        private readonly ApplicationDbContext _db;
        public TransportService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Transport> Create(Models.Transport transport)
        {
            _db.transports.Add(transport);
            await _db.SaveChangesAsync();
            return transport;
        }

        public async Task<Models.Transport> EditTransport(int id, Models.Transport transport)
        {
            //recuperer une par son id : 
            var transportInDb = _db.transports.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(transport);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le transport update 
            return transport;
        }

        public async Task<IEnumerable<Models.Transport>> GetAllTransports()
        {
            // retourner une liste des transports : 
            return await _db.transports.ToListAsync();
        }
        public async Task<Models.Transport> DeleteTransport(int id)
        {
            var transportInDb = await _db.transports.FindAsync(id);
            _db.Remove(transportInDb);
            await _db.SaveChangesAsync();
            return transportInDb;

        }


     
    }
}
