using GuideTouristiqueApp.Areas.SiteTouristique.Services;
using GuideTouristiqueApp.Areas.SiteTouristique.Sites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.SiteTouristique.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteTouristiqueController : ControllerBase
    {
        private ISiteServices siteService;
        public SiteTouristiqueController(ISiteServices siteService)
        {
            this.siteService = siteService;
        }
        //pour récuperer un site :-------------------------------------------------------------------------------------------------------------------------
        [HttpGet("sites")]
        public async Task<IActionResult> GetSites()
        {
            var sites = await siteService.GetAllSites();
            return Ok(sites);
        }
        //pour créeer un site----------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateSite(Models.SiteTouristique site)
        {
            if (!ModelState.IsValid) return BadRequest();
            var sites = await siteService.Create(site);
            return Ok(sites);
        }
        //Pour modifier un site :---------------------------------------------------------------------------------------------------------------------------
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateSite(int id, Models.SiteTouristique site)
        {
            var sites = await siteService.EditSite(id, site);
            return Ok(sites);
        }
        //Pour supprimer un site :-----------------------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSites(int id)
        {

            var service = await siteService.DeleteSite(id);
            return Ok(service);
        }



    }
}
