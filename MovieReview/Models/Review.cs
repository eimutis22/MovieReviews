using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Review ID")]
        public int ReviewId { get; set; }
        
        [Display(Name = "User ID")]
        [ForeignKey("assocUsers")]
        public int UserID { get; set; }

        [Display(Name = "Imdb ID")]
        public int ImdbId { get; set; }

        [Display(Name = "Review Comment")]
        public string ReviewComment { get; set; }
        
        [Column(TypeName = "date")]
        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Star Rating")]
        public DateTime StarRating { get; set; }

        public virtual User assocUsers { get; set; }
    }
}