﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BuySell.Utilities;
using Microsoft.AspNetCore.Identity;

namespace BuySell.Models
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        [MaxLength(50)]
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
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public AppUser()
        {
            Orders = new HashSet<Order>();
            Carts = new HashSet<Cart>();
        }
    }
}
