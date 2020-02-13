using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.Models
{
    public class StockViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public StockViewModel()
        {
            Products = new HashSet<ProductViewModel>();
        }
    }
}
