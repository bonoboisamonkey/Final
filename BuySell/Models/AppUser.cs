﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BuySell.Models
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [Required]
        public DateTime RegistredDate { get; set; }
        public bool IsSubscribed { get; set; }
        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
