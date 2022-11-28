using FamilyBudgetApp.Data.Config;
using FamilyBudgetApp.Data.Models;
using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            modelBuilder.ApplyConfiguration(new BudgetConfiguration());
        }
    }
}
