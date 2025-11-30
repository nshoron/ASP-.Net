using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.EF;
using WebApplication4.Controllers;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        UMSModelEntities1 db = new UMSModelEntities1();
        // GET: Student
        public ActionResult Index()
        {
            var s = new Student()
            {
                Name = "S",
                Address = "v"
                
            };
            db.Students.Add(s);
            db.SaveChanges();
          
            


            return View();
        }

        public ActionResult list()
        {
            var data = db.Students.ToList();
            return View(data);
        }
    }
}