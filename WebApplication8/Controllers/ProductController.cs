using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.EF;
using System.Data.Entity;


namespace WebApplication8.Controllers
{
    public class ProductController : Controller
    {
        ProductDBEntities db = new ProductDBEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProductList ()
        {
            ViewBag.Catagories = db.Catagories.ToDictionary(c=>c.Id,c=>c.Name);
            var products = db.Products.ToList();
            return View(products);

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product p = new Product { Id = id };

            db.Products.Attach(p);
            db.Products.Remove(p);
            db.SaveChanges();

            return RedirectToAction("ProductList"); ;

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = db.Products.Find(id);

            // Load category list
            ViewBag.Catagories = db.Catagories.ToList();

            return View(product);

        }
        [HttpPost]
        public ActionResult Edit(Product K)
        {
            db.Entry(K).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public ActionResult ProductCreate()
        {
            ViewBag.Catagories = db.Catagories.ToList();
            return View(new Product());
        }
        [HttpPost]
        public ActionResult ProductCreate(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            TempData["Mgs"] = "Product Added Succesfully";
            return RedirectToAction("ProductList");
        }
    }
}