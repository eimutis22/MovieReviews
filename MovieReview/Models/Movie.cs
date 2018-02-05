using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Imdb ID")]
        public int ImdbID { get; set; }

        [Display(Name = "Movie Title")]
        public int Title { get; set; }

        [Display(Name = "Movie Year")]
        public int Year { get; set; }
    }
}