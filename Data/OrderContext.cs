using Microsoft.EntityFrameworkCore;
using VerstaTestVatnik.Models;

namespace VerstaTestVatnik.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
