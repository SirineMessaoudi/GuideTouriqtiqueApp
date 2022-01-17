using GuideTouristiqueApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using GuideTouristiqueApp.Models;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Areas.Transport.Controllers
{
    [Area("Transport")]
    public class TransportController : Controller
    {
        //action qui lister tous le contenu :
        private readonly ApplicationDbContext _db;
        public TransportController(ApplicationDbContext db)
        {
            _db = db;
        }
        //HTTP-GET : 
        //Async |await permettent d'appeler +ieurs fonctionnalités d'une maniere asynchrone
        // pour Lister :----------------------------------------------------------------------------------------------------------------------------- 
        public async Task<IActionResult> Index()
        {
            return View(await _db.transports.ToListAsync());
        }
        // pour Create :----------------------------------------------------------------------------------------------------------------------------- 
        //HTTP-GET 
        public IActionResult Create()
        {
            return View();
        }
      
        //HTTP-POST
        [HttpPost]
        public async Task<IActionResult> Create(Models.Transport transport)
        {
            if (ModelState.IsValid)
            //Si le modèle introduit est valide
            {
                //ajouter category : 
                _db.transports.Add(transport);
                //enregistrer les modification : 
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index", "transportT");
                //si vous avez le controle sur le meme controller : redirection  
                return RedirectToAction(nameof(Index));
            }
            return View(transport);
        }
        //pour edit get pour récuperer à partir de l'id  :-----------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var transport = await _db.transports.FindAsync(id);
            return View(transport);
        }
        //pour edit post pour sauvegarder 'save' l'update:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.Transport transport)
        {
            if (ModelState.IsValid)
            {
                //Update peut être remplacé par mapping automatique ou manuelle

                _db.Update(transport);
                //enregistrer les modification :
                await _db.SaveChangesAsync();
                //  redirection
                return RedirectToAction(nameof(Index));
            }
            return View(transport);
        }
        //pour delete get pour récuperer à partir de l'id: -----------------------------------------------------------------------------------------
        //HTTP-GET
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var transport = await _db.transports.FindAsync(id);
            return View(transport);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            //rechercher par id : 
            var hot = await _db.transports.FindAsync(id);
            //si null donc rien faire:
            if (hot == null) return View();
            //sinon supprimer
            _db.transports.Remove(hot);
            //enregistrer les modification :
            await _db.SaveChangesAsync();
            //  redirection
            return RedirectToAction(nameof(Index));
        }
        //HTTP-GET
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var transport = await _db.transports.FindAsync(id);
            return View(transport);
        }
    }
}
