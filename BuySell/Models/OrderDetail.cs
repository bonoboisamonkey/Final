using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.Models
{
    public class OrderDetail
    {
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Order Order { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderUnitPrice { get; set; }
    }
}
