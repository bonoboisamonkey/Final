using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ICollection<Product> RelatedProducts { get; set; }
    }
}
