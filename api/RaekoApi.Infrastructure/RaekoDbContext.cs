using Microsoft.EntityFrameworkCore;
using RaekoApi.Domain.Models;

namespace RaekoApi.Infrastructure
{
    public class RaekoDbContext : DbContext
    {
        public RaekoDbContext(DbContextOptions<RaekoDbContext> options) : base(options) { }

        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Transaction> Transactions => Set<Transaction>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Transaction>()
                .Property(transaction => transaction.Amount)
                .HasColumnType("decimal(18,2)");
            builder.Entity<Category>()
                .HasIndex(category => new { category.Name, category.Type })
                .IsUnique();
        }
    }
}
