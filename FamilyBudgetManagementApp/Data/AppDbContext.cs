using FamilyBudgetApp.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace FamilyBudgetManagementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        //DbSet is made virtual for mocking purposes
        public virtual DbSet<Budget> Bugets { get; set; }
    }
}
