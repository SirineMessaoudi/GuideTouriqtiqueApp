using GuideTouristiqueApp.Areas.Hotel.Services;
using GuideTouristiqueApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Hotel.Services
{
    public class HotelService : IHotelServices
    {
        private readonly ApplicationDbContext _db;
        public HotelService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Hotel> Create(Models.Hotel hotel)
        {
            _db.hotels.Add(hotel);
            await _db.SaveChangesAsync();
            return hotel;
        }

        public async Task<Models.Hotel> EditHotel(int id, Models.Hotel hotel)
        {
            //recuperer une par son id : 
            var hotelInDb = _db.hotels.SingleOrDefault(c => c.Id == id);
            //faire l'update sur Json : 
            _db.Update(hotel);
    
            //enregister les changement : 
            await _db.SaveChangesAsync();
            //retourner le hotel update 
            return hotel;
        }

        public async Task<IEnumerable<Models.Hotel>> GetAllHotels()
        {
            // retourner une liste des hotels : 
            return await _db.hotels.ToListAsync();
        }
        public async Task<Models.Hotel> DeleteHotel(int id)
        {
            var hotelInDb = await _db.hotels.FindAsync(id);
            _db.Remove(hotelInDb);
            await _db.SaveChangesAsync();
            return hotelInDb;

        }


     
    }
}
