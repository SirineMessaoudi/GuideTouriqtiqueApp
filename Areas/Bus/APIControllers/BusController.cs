using GuideTouristiqueApp.Areas.Bus.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Bus.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiviteController : ControllerBase
    {
        private IBusServices busService;
        public ActiviteController(IBusServices busService)
        {
            this. busService = busService;
        }
        //pour récuperer un bus :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("buses")]
        public async Task<IActionResult> GetBuses()
        {
            var buses = await busService.GetAllBuses();
            return Ok(buses);
        }
        //pour créeer un Bus----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateBus(Models.Bus bus)
        {
            if (!ModelState.IsValid) return BadRequest();
            var buses = await busService.Create(bus);
            return Ok(buses);
        }
        //Pour modifier un bus :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateBus(int id, Models.Bus bus)
        {
            var buses = await busService.EditBus(id, bus);
            return Ok(buses);
        }
        //Pour supprimer un buse :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBuses(int id)
        {

            var bus = await busService.DeleteBus(id);
            return Ok(bus);
        }



    }
}
