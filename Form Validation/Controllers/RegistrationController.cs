using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form_Validation.Models;

namespace Form_Validation.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Registration( Student s)

        {
            if(ModelState.IsValid)
            {
                TempData["MSG"]= "Summited";
                RedirectToAction("Index");
            }
            return View(s);
           
        }
    }
}