using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.ViewModels
{
    public class StockViewModel
    {
        [Required]
        public int Count { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public ProductViewModel Product { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
