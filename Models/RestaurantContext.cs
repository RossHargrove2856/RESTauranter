using Microsoft.EntityFrameworkCore;

namespace RESTaurant.Models
{
    public class RestaurantContext : DbContext
    {
                public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) {}
                public DbSet<Review> Users { get; set; }
    }
}