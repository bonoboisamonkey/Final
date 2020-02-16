using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.Models
{
    public class Stock
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
