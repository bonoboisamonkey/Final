using BuySell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        [MaxLength(30)]
        public string CommentatorName { get; set; }
        [Required]
        [MaxLength(50)]
        public string CommentTitle { get; set; }
        [Required]
        [MaxLength(200)]
        public string CommentBody { get; set; }
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public Roles AddedBy { get; set; }
        [MaxLength(20)]
        public Roles ModifiedBy { get; set; }
        [MaxLength(20)]
        public Roles DeletedBy { get; set; }
        public ProductViewModel Product { get; set; }
        public int? ProductId { get; set; }
        public BlogViewModel Blog { get; set; }
        public int? BlogId { get; set; }
    }
}
