using Microsoft.EntityFrameworkCore;
using MVCVidly.Models;

namespace MVCVidly.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        //this name should be polurized
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MovieCustomer> MovieCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCustomer>()
                .HasKey(cs => new { cs.MovieId, cs.CustomerId });
        }

    }
}
