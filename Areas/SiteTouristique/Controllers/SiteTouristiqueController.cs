using GuideTouristiqueApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using GuideTouristiqueApp.Models;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.SiteTouristique.Controllers
{
    [Area("SiteTouristique")]
    public class SiteController : Controller
    {
        //action qui lister tous le contenu :
        private readonly ApplicationDbContext _db;
        public SiteController(ApplicationDbContext db)
        {
            _db = db;
        }
        //HTTP-GET : 
        //Async |await permettent d'appeler +ieurs fonctionnalités d'une maniere asynchrone
        // pour Lister :----------------------------------------------------------------------------------------------------------------------------- 
        public async Task<IActionResult> Index()
        {
            return View(await _db.sites.ToListAsync());
        }
        // pour Create :----------------------------------------------------------------------------------------------------------------------------- 
        //HTTP-GET 
        public IActionResult Create()
        {
            return View();
        }
      
        //HTTP-POST
        [HttpPost]
        public async Task<IActionResult> Create(Models.SiteTouristique site)
        {
            if (ModelState.IsValid)
            //Si le modèle introduit est valide
            {
                //ajouter category : 
                _db.sites.Add(site);
                //enregistrer les modification : 
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index", "SiteT");
                //si vous avez le controle sur le meme controller : redirection  
                return RedirectToAction(nameof(Index));
            }
            return View(site);
        }
        //pour edit get pour récuperer à partir de l'id  :-----------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var site = await _db.sites.FindAsync(id);
            return View(site);
        }
        //pour edit post pour sauvegarder 'save' l'update:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.SiteTouristique site)
        {
            if (ModelState.IsValid)
            {
                //Update peut être remplacé par mapping automatique ou manuelle

                _db.Update(site);
                //enregistrer les modification :
                await _db.SaveChangesAsync();
                //  redirection
                return RedirectToAction(nameof(Index));
            }
            return View(site);
        }
        //pour delete get pour récuperer à partir de l'id: -----------------------------------------------------------------------------------------
        //HTTP-GET
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var site = await _db.sites.FindAsync(id);
            return View(site);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            //rechercher par id : 
            var site = await _db.sites.FindAsync(id);
            //si null donc rien faire:
            if (site == null) return View();
            //sinon supprimer
            _db.sites.Remove(site);
            //enregistrer les modification :
            await _db.SaveChangesAsync();
            //  redirection
            return RedirectToAction(nameof(Index));
        }
        //HTTP-GET
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var site = await _db.sites.FindAsync(id);
            return View(site);
        }
    }
}
