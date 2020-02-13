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
        public string AddedBy { get; set; }
        [MaxLength(20)]
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public ICollection<PhotoViewModel> Photos { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
