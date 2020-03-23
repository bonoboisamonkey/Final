using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.ViewModels
{
    public class HomePageViewModel
    {
        public ICollection<Product> AllProducts { get; set; }
        public ICollection<Product> BestRatedProducts { get; set; }
        public ICollection<Product> OnSaleProducts { get; set; }
        public ICollection<Blog> Slides { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
