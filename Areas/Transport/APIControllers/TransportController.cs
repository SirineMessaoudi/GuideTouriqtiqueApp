using GuideTouristiqueApp.Areas.Transport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Transport.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        private ITransportServices transportService;
        public TransportController(ITransportServices transportService)
        {
            this. transportService = transportService;
        }
        //pour récuperer un Transport :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("transports")]
        public async Task<IActionResult> GetTransports()
        {
            var transports = await transportService.GetAllTransports();
            return Ok(transports);
        }
        //pour créeer un Transport----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateTransport(Models.Transport transport)
        {
            if (!ModelState.IsValid) return BadRequest();
            var transports = await transportService.Create(transport);
            return Ok(transports);
        }
        //Pour modifier un Transport :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateTransport(int id, Models.Transport transport)
        {
            var transports = await transportService.EditTransport(id, transport);
            return Ok(transports);
        }
        //Pour supprimer un Transport :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransports(int id)
        {

            var Transport = await transportService.DeleteTransport(id);
            return Ok(Transport);
        }



    }
}
