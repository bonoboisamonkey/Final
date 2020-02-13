using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.Models
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public CategoryViewModel Parent { get; set; }
        public int? ParentId { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}
