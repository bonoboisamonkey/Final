using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BuySell.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Product Price")]
        public decimal ProductPrice { get; set; }
        [Required]
        [DisplayName("Product Discount")]
        public int ProductDiscount { get; set; }
        [Required]
        [DefaultValue(0)]
        [DisplayName("Product Rating")]
        public byte ProductRating { get; set; }
        [Required]
        [MaxLength(500)]
        [DisplayName("Product Details")]
        public string ProductDetails { get; set; }
        [Required]
        [DisplayName("Product Count")]
        public int ProductCount { get; set; }
        [Required]
        [DisplayName("Product Availablity Status")]
        public bool IsAvailable { get; set; }
        [DisplayName("Product Remove Status")]
        public bool IsDeleted { get; set; }
        [DisplayName("Additon Date")]
        public DateTime AddedDate { get; set; }
        [DisplayName("Modification Date")]
        public DateTime? ModifiedDate { get; set; }
        [DisplayName("Deletion Date")]
        public DateTime? DeletedDate { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
