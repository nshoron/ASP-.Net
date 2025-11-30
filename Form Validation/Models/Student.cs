using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Form_Validation.Models.CustomValidation;

namespace Form_Validation.Models
{
    public class Student
    {
        [Required (ErrorMessage ="You must fill Name ")]
        [RegularExpression(@"^[A-Za-z\s)]+$", ErrorMessage ="Name cannot contains special charecter or numbers")]
        public string Name { get; set; }
        [AiubEmail(ErrorMessage ="Email format is invalid")]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}