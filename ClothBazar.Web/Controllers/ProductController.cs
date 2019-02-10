using ClothBazar.entities;
using ClothBazar.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        public ProductService context = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductsTable(string search)
        {
          var products=  context.GetAll();
            if (search != null)
            {
                products = products.Where(p => p.Name == search && p.Name != null).ToList();
            }
            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            context.CreateProduct(product);
            return RedirectToAction("ProductsTable");

           
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
          var product=  context.GetProduct(id);
            return PartialView(product);
        }
    [HttpPost]
        public ActionResult Edit(Product product)
        {
            context.UpdateProduct(product);
            return RedirectToAction("ProductsTable");
        }
        [HttpPost]
        public ActionResult Delete( int id)
        {
            context.DeleteProduct(id);
            return RedirectToAction("ProductsTable");

        }

    }
}