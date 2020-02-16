using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string TrackingNumber { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotalPrice { get; set; }
        public AppUser Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
