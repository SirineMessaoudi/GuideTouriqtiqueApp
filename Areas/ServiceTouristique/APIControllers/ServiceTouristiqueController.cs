
using GuideTouristiqueApp.Areas.ServiceTouristique.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.ServiceTouristique.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTouristiqueController : ControllerBase
    {
        private IServiceTouristiqueServices serviceService;
        public ServiceTouristiqueController(IServiceTouristiqueServices serviceService)
        {
            this. serviceService = serviceService;
        }
        //pour récuperer un service :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("services")]
        public async Task<IActionResult> GetServices()
        {
            var services = await serviceService.GetAllServices();
            return Ok(services);
        }
        //pour créeer un Service----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateService(Models.ServiceTouristique service)
        {
            if (!ModelState.IsValid) return BadRequest();
            var services = await serviceService.Create(service);
            return Ok(services);
        }
        //Pour modifier un service :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateService(int id, Models.ServiceTouristique service)
        {
            var services = await serviceService.EditService(id, service);
            return Ok(services);
        }
        //Pour supprimer un service :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServices(int id)
        {

            var service = await serviceService.DeleteService(id);
            return Ok(service);
        }



    }
}
