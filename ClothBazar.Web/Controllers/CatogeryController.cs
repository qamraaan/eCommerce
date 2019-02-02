using ClothBazar.Database;
using ClothBazar.entities;
using ClothBazar.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class CatogeryController : Controller
    {
        public CatogeryService context = new CatogeryService();
        public ActionResult Index()
        {
          var catogeries=  context.GetAll();
            return View(catogeries);
        }
        // GET: Catogery
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Catogery catogery)
        {
            context.CreateCatogery(catogery);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
      {
           var catogery= context.EditCatogery(id);
            return View(catogery);
        }
       [HttpPost]
       public ActionResult Edit(Catogery catogery)
        {
            context.UpdateCatogery(catogery);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(Catogery catogery)
        {
           var cat= context.GetCatogery(catogery.ID);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            context.DeleteCatogery(id);
            return RedirectToAction("Index");
        }
    }
}