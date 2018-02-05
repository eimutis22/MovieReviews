using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        public int FirstName { get; set; }

        [Display(Name = "Last Name")]
        public int LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public int DOB { get; set; }

        [Display(Name = "Email")]
        public int Email { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}