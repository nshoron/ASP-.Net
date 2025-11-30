using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.EF;

namespace WebApplication6.Controllers
{
    public class StudentController : Controller
    {
        SMMODELEntities db = new SMMODELEntities();
        // GET: Student
        public ActionResult Index()
        {
            var s = new Student()
            {
                Id = 3,
                Name = "Shoron",
                Address = "Dhaka"

            };
            db.Students.Add(s);
            db.SaveChanges();
            return View();
        }
        public ActionResult StudentDetails()
        {
            var data = db.Students.ToList();
            return View(data);
        }
    }
}