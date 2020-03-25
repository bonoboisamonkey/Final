using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public AppUser Costumer { get; set; }
        public int CostumerId { get; set; }

        public bool isDeleted { get; set; } = false;
    }
}
