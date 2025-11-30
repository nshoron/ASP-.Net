using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student[] student = new Student[10];
            for(int i=1; i<=10; i++)
            {
                student[i - 1] = new Student()
                {
                    Name = "SHORON" +1,
                    Id=i, 
                    Address="DHAKA",
                    Cgpa=3.75
                    



                };
            }
            return View(student);
        }
     public ActionResult Details()
        {
            Student S = new Student();
            S.Name = "SHoron";
            S.Id = 12;
            S.Address = "DHaka";
            S.Cgpa = 3.75;
            return View(S);
        }
    }
    
}