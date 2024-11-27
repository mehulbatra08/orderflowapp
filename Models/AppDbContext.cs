using Microsoft.EntityFrameworkCore;

namespace OrderFlowApp.Models {
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}