using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuySell.Models
{
    public class Blog
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string BlogTitle { get; set; }
        [Required]
        [MaxLength(300)]
        public string BlogBody { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public Roles AddedBy { get; set; }
        [MaxLength(20)]
        public Roles ModifiedBy { get; set; }
        public Roles DeletedBy { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
