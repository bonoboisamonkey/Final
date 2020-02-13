using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.ViewModels
{
    public class ProductViewModel
    {
        public CategoryViewModel Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public StockViewModel Stock { get; set; }
        [Required]
        public int StockId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }
        [Required]
        public int ProductDiscount { get; set; }
        [Required]
        [DefaultValue(0)]
        public byte ProductRating { get; set; }
        [Required]
        [MaxLength(500)]
        public string ProductDetails { get; set; }
    }
}
