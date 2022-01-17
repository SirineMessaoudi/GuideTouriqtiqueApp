using GuideTouristiqueApp.Areas.Hotel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Hotel.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelServices hotelService;
        public HotelController(IHotelServices hotelService)
        {
            this. hotelService = hotelService;
        }
        //pour récuperer un hotel :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("hotels")]
        public async Task<IActionResult> GetHotels()
        {
            var hotels = await hotelService.GetAllHotels();
            return Ok(hotels);
        }
        //pour créeer un hotel----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateHotel(Models.Hotel hotel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var hotels = await hotelService.Create(hotel);
            return Ok(hotels);
        }
        //Pour modifier un hotel :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateHotel(int id, Models.Hotel hotel)
        {
            var hotels = await hotelService.EditHotel(id, hotel);
            return Ok(hotels);
        }
        //Pour supprimer un hotel :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotels(int id)
        {

            var hotel = await hotelService.DeleteHotel(id);
            return Ok(hotel);
        }



    }
}
