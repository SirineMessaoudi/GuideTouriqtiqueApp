using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Hotel.Services
{
    public interface IHotelServices
    {
        //les fonctions qu'on va etre les definer dans le hotel hotelService:
        Task<IEnumerable<Models.Hotel>> GetAllHotels();
        Task<Models.Hotel> EditHotel(int id, Models.Hotel Hotel);
        Task<Models.Hotel> Create(Models.Hotel Hotel);
        Task<Models.Hotel> DeleteHotel(int id);
    }
}
