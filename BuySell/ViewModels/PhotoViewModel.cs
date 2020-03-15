using BuySell.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.ViewModels
{
    public class PhotoViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public IFormFile PhotoPath { get; set; }
        public Product Product { get; set; }
        public int? ProductId { get; set; }
        public Blog Blog { get; set; }
        public int? BlogId { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Roles AddedBy { get; set; }
        public Roles ModifiedBy { get; set; }
        public Roles DeletedBy { get; set; }
    }
}
