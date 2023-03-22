using Centaury.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Api.Infra.Infrastructure.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override  void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
            modelBuilder.Entity<Office>().HasKey(x => x.Id);
            modelBuilder.Entity<Sector>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().HasKey(x => x.Id);

            modelBuilder.Entity<Office>()
                .HasOne(p => p.Sector);

        }
    }
}
