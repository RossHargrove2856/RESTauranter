using System;
using System.ComponentModel.DataAnnotations;
using RESTaurant.Models;
using RESTaurant.Models.Validations;

namespace RESTaurant.Models
{
    public class ReviewViewModel : BaseEntity
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Restaurant Name")]
        public string restaurant_name { get; set; }

        [Required]
        [Range(0,5)]
        [Display(Name = "Stars")]
        public int stars { get; set; }

        [Required]
        [MinLength(10)]
        [Display(Name = "Review")]
        public string review { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date of Visit")]
        // [ValidateDate]
        public DateTime date_of_visit { get; set; }
    }
}