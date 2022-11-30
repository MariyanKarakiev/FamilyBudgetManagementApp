using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetManagementApp.Models;

namespace FamilyBudgetApp.Data.Config
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData
                (
                     new Transaction
                     {
                         Id = Guid.NewGuid(),
                         Name= "Initial",
                         Amount=100,
                         BudgetId=1,
                         Currency= Enums.Currency.BGN,
                         Type = Enums.TransactionType.Income,
                         CreatedOn=DateTime.Now,
                         IsReccuring=false
                     }
                );
        }
    }
}

