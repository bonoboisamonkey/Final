using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.ViewModels
{
    public class OrderViewModel
    {
        [Required]
        [MaxLength(50)]
        public string TrackingNumber { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotalPrice { get; set; }
        public AppUserViewModel Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
