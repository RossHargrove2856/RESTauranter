using System;

namespace RESTaurant.Models
{
    public class Review : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string restaurant_name { get; set; }
        public int stars { get; set; }
        public string review { get; set; }
        // [ValidateDate]
        public DateTime date_of_visit { get; set; }
    }
}