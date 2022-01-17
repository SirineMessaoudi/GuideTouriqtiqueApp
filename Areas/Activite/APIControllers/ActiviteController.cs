using GuideTouristiqueApp.Areas.Activite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Activite.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiviteController : ControllerBase
    {
        private IActiviteServices activiteService;
        public ActiviteController(IActiviteServices activiteService)
        {
            this. activiteService = activiteService;
        }
        //pour récuperer un Activite :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("activites")]
        public async Task<IActionResult> GetActivites()
        {
            var activites = await activiteService.GetAllActivites();
            return Ok(activites);
        }
        //pour créeer un Activite----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateActivite(Models.Activite activite)
        {
            if (!ModelState.IsValid) return BadRequest();
            var activites = await activiteService.Create(activite);
            return Ok(activites);
        }
        //Pour modifier un Activite :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateActivite(int id, Models.Activite activite)
        {
            var activites = await activiteService.EditActivite(id, activite);
            return Ok(activites);
        }
        //Pour supprimer un Activitee :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivites(int id)
        {

            var activite = await activiteService.DeleteActivite(id);
            return Ok(activite);
        }



    }
}
