using Microsoft.EntityFrameworkCore;
using Catapusan_Midterm_Store.Models;

namespace Catapusan_Midterm_Store.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
    }
}