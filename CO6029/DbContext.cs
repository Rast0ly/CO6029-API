using CO6029.Data;
using Microsoft.EntityFrameworkCore;

namespace CO6029
{
    // Models/Database.cs
    public class Database : DbContext
    {
        // Create a DbSet for each Model class

        public Database(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().Property(e => e.Price).HasColumnType("money");
            modelBuilder.Entity<Customer>().HasKey(x => x.Id);
            modelBuilder.Entity<Customer>().HasMany(x => x.Address).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<Order>().HasMany(x => x.OrderLines).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<OrderLine>().HasOne(x => x.Product).WithMany(x => x.OrderLines).HasForeignKey(x => x.ProductId);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}