using GuideTouristiqueApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using GuideTouristiqueApp.Models;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Bus.Controllers
{
    [Area("Bus")]
    public class BusController : Controller
    {
        //action qui lister tous le contenu :
        private readonly ApplicationDbContext _db;
        public BusController(ApplicationDbContext db)
        {
            _db = db;
        }
        //HTTP-GET : 
        //Async |await permettent d'appeler +ieurs fonctionnalités d'une maniere asynchrone
        // pour Lister :----------------------------------------------------------------------------------------------------------------------------- 
        public async Task<IActionResult> Index()
        {
            return View(await _db.buses.ToListAsync());
        }
        // pour Create :----------------------------------------------------------------------------------------------------------------------------- 
        //HTTP-GET 
        public IActionResult Create()
        {
            return View();
        }
      
        //HTTP-POST
        [HttpPost]
        public async Task<IActionResult> Create(Models.Bus bus)
        {
            if (ModelState.IsValid)
            //Si le modèle introduit est valide
            {
                //ajouter category : 
                _db.buses.Add(bus);
                //enregistrer les modification : 
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index", "busT");
                //si vous avez le controle sur le meme controller : redirection  
                return RedirectToAction(nameof(Index));
            }
            return View(bus);
        }
        //pour edit get pour récuperer à partir de l'id  :-----------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var bus = await _db.buses.FindAsync(id);
            return View(bus);
        }
        //pour edit post pour sauvegarder 'save' l'update:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.Bus bus)
        {
            if (ModelState.IsValid)
            {
                //Update peut être remplacé par mapping automatique ou manuelle

                _db.Update(bus);
                //enregistrer les modification :
                await _db.SaveChangesAsync();
                //  redirection
                return RedirectToAction(nameof(Index));
            }
            return View(bus);
        }
        //pour delete get pour récuperer à partir de l'id: -----------------------------------------------------------------------------------------
        //HTTP-GET
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var bus = await _db.buses.FindAsync(id);
            return View(bus);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            //rechercher par id : 
            var bus = await _db.buses.FindAsync(id);
            //si null donc rien faire:
            if (bus == null) return View();
            //sinon supprimer
            _db.buses.Remove(bus);
            //enregistrer les modification :
            await _db.SaveChangesAsync();
            //  redirection
            return RedirectToAction(nameof(Index));
        }
        //HTTP-GET
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var bus = await _db.buses.FindAsync(id);
            return View(bus);
        }
    }
}
