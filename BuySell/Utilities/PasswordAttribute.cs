using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Utilities
{
    public class PasswordAttribute : ValidationAttribute
    {
        public PasswordAttribute()
        {
            this.ErrorMessage = "Password doesn't conta @ or _";
        }

        public override bool IsValid(object value)
        {

            string password = value.ToString();

            if (password.Contains("@") || password.Contains("_"))
                return true;
            else
                return false;
        }
    }
}
