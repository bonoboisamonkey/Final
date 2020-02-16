using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Stock Stock { get; set; }
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
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
