using FamilyBudgetApp.Data.Models;
using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;


namespace FamilyBudgetManagementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Budget> Bugets { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Budget>().HasData(new Budget {Id = (byte)1, Balance = 0.0M});
        }
    }
}
