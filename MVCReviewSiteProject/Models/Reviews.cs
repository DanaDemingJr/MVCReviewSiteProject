using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Reviews
    {
        public int ID { get; set; }
        public string ReviewerName { get; set; }
        public string GadgetReviewed { get; set; }
        public int DateReviewed { get; set; }
        public string Review { get; set; }
        [Required(ErrorMessage = "A rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int StarRating { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}