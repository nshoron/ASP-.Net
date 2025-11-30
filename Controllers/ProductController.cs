using ProductCRUD.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
        ProductCRUDEntities db = new ProductCRUDEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductList()
        {
            ViewBag.Categories = db.Categories.ToDictionary(c => c.Id, c => c.Name);
            var product = db.Products.ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult ProductCreate()
        {
            ViewBag.Categories = db.Categories.ToList();

            return View(new Product());
        }

        [HttpPost]
        public ActionResult ProductCreate(Product product)
        {

            db.Products.Add(product);
            db.SaveChanges();
            TempData["msg"] = product.Name + " Added Successfully";
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult ProductUpdate()
        {
            ViewBag.Categories = db.Categories.ToList();

            return View(new Product());
        }

        [HttpPost]
        public ActionResult ProductUpdate(Product product)
        {

            db.Products.Add(product);
            db.SaveChanges();
            TempData["msg"] = product.Name + " Added Successfully";
            return RedirectToAction("ProductList");
        }
    }
}