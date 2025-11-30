using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Form_Validation.Models.CustomValidation
{
    public class AiubEmail : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value== null)
            {
                return false;
            }
            string email = value.ToString();
            string pattern = @"^\d{2}-\d{5}-\d@student\.aiub\.edu$";
            return Regex.IsMatch(email, pattern);
        }

    }
}