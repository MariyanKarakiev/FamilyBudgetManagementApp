using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetManagementApp.Models;
using FamilyBudgetApp.Data.Models;
using FamilyBudgetApp.Data.Enums;

namespace FamilyBudgetApp.Data.Config
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            var objs = GenerateTransactions(5);
            builder.HasData(objs);
        }

        public static List<Transaction> GenerateTransactions(int count)
        {
            var transactions = new List<Transaction>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                var transaction = new Transaction
                {
                    Id = Guid.NewGuid(),
                    Type = (TransactionType)random.Next(0, 2),
                    Currency = Currency.BGN,
                    Name = $"Transaction {i + 1}",
                    Amount = (decimal)random.Next(1, 1000),
                    CreatedOn = DateTime.Now.AddDays(-random.Next(1, 300)),
                    ReccursOn = DateTime.Now.AddDays(random.Next(1, 30)),
                    TimesReccuring = (ushort)random.Next(1, 10),
                    IsReccuring = random.Next(2) == 0,
                    BudgetId = 1
                };

                transactions.Add(transaction);
            }

            return transactions;
        }
    }
}

