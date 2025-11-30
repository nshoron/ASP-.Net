using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.EF;

namespace WebApplication7.Controllers
{
    public class ProductController : Controller
    {
        ProductEntities db = new ProductEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            ViewBag.Categories = db.Catagories.ToList();
            return View(new Product());
        }
        [HttpPost]
        public ActionResult CreateProduct(Product p)

        {
            db.Products.Add(p);
            db.SaveChanges();
            return View(p);
        }
       
        [HttpGet]
        public ActionResult ShowInfo()
        {
            ViewBag.Catagories = db.Catagories.ToList();
            var data = db.Products.ToList();
            return View(data);
        }
    }
}