using Microsoft.EntityFrameworkCore;

namespace WebApplicationVerstaTest.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
