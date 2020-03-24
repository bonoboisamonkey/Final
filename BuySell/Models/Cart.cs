using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class Cart
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public AppUser Costumer { get; set; }
        public int CostumerId { get; set; }
    }
}
