using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetApp.Data.Models;

namespace FamilyBudgetApp.Data.Config
{
    public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            builder.HasData
                (
                     new Budget
                     {
                         Id = (byte)1,
                         Balance = 100.0M
                     }
                );
        }
    }
}

