using AkijFoodProjectIntern.Data;
using AkijFoodProjectIntern.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFoodProjectIntern.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class tblColdDrinksController : Controller
    {
        private ApplicationDbContext _db;
        public tblColdDrinksController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.tblColdDrinks.ToList();
            return View(data);
        }

        // Get Create Action Method
        public ActionResult Create(bool Issuccess = false)
        {
            ViewBag.issuccess = Issuccess;
            return View();
        }

        // Post Create Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create( tblColdDrinks coldDrinks)
        {
            if (ModelState.IsValid)
            {
                if (coldDrinks.numQuantity < 500)
                {
                    return RedirectToAction(null, new { Issuccess =true});
                }
                _db.tblColdDrinks.Add(coldDrinks);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName:nameof(Index));
            }
            else
            {
                return View(coldDrinks);
            }
            
        }

        //Get Edit Action Method
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var newItem = _db.tblColdDrinks.Find(id);
            if (newItem == null) 
            {
                return NotFound();
            }
            return View(newItem);
        }

        //Post Edit Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(tblColdDrinks coldDrinks)
        {
            if (ModelState.IsValid)
            {
                _db.Update(coldDrinks);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(coldDrinks);
        }

        //Get Details action method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var newItem = _db.tblColdDrinks.Find(id);
            if (newItem == null)
            {
                return NotFound();
            }
            return View(newItem);
        }

        //Post Details action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(tblColdDrinks coldDrinks)
        {
            return RedirectToAction(actionName: nameof(Index));
        }

        //Get Delete action method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var newItem = _db.tblColdDrinks.Find(id);
            if (newItem == null)
            {
                return NotFound();
            }
            return View(newItem);
        }

        //Post Delete action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, tblColdDrinks coldDrinks)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != coldDrinks.intColdDrinksId)
            {
                return NotFound();
            }

            var newItem = _db.tblColdDrinks.Find(id);
            if (newItem == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(newItem);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(newItem);
        }
    }
}
