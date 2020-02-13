using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.ViewModels
{
    public class CategoryViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public CategoryViewModel Parent { get; set; }
        public int? ParentId { get; set; }
    }
}
