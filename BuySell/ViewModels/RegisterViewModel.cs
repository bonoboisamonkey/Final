using BuySell.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string UserSurname { get; set; }
        [Required]
        [Password]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string City { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string PostalCode { get; set; }
        [Required]
        public DateTime RegistredDate { get; set; } = DateTime.Now;
    }
}
