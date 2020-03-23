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
        [StringLength(maximumLength: 20, MinimumLength = 6)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 6)]
        public string UserSurname { get; set; }
        [Required]
        [Password]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [Required]
        public DateTime RegistredDate { get; set; }
    }
}
