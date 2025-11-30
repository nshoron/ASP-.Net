using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace WebApplication2.Models
{
    public class login
    {
        [Required(ErrorMessage ="Email is required")]
        [RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w{2,4}$",
            ErrorMessage = "Invalid email format")]
        public string email { get; set;}

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^(?:\+88|88)?01[3-9]\d{8}$",
           ErrorMessage = "Invalid Bangladeshi phone number")]
        public string Phone { get; set; }



    }
}