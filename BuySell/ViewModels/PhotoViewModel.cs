using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.ViewModels
{
    public class PhotoViewModel
    {
        [Required]
        [MaxLength(100)]
        public string PhotoPath { get; set; }
        public ProductViewModel Product { get; set; }
        public int? ProductId { get; set; }
        public BlogViewModel Blog { get; set; }
        public int? BlogId { get; set; }

    }
}
