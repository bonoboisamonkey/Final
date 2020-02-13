using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.Models
{
    public class PhotoViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string PhotoPath { get; set; }
        public ProductViewModel Product { get; set; }
        public int? ProductId { get; set; }
        public Blog Blog { get; set; }
        public int? BlogId { get; set; }

    }
}
