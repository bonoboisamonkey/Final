using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.ViewModels
{
    public class ShopFilterViewModel
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Dictionary<string, int> Brands { get; set; }

    }
}
