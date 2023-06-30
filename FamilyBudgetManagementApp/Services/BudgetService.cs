using FamilyBudgetApp.Data.Models;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services.Contracts;
using FamilyBudgetManagementApp.ViewModels;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FamilyBudgetManagementApp.Services
{
    public class BudgetService : IBudgetService
    {
        private AppDbContext dbContext;
        private static readonly JsonSerializerOptions _options =
            new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public BudgetService(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task ChargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfNull(budget);

            budget.Balance += amount;

            dbContext.SaveChanges();
        }

        public async Task DischargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfNull(budget);

            if (budget.Balance - amount < 0)
            {
                throw new ArgumentException("Out of funds!");
            }

            budget.Balance -= amount;

            dbContext.SaveChanges();
        }
        public async Task<BudgetViewModel> GetStatistics()
        {
            var budget = await dbContext.Bugets.Where(b => b.Id == 1).Include(b=>b.Transactions).FirstOrDefaultAsync();

            CheckIfNull(budget);

            var dates = new List<int>();
            var transactionAmounts = new List<decimal>();

            budget.Transactions
                .Select(t => new
                {
                    Amount = t.Amount,
                    Date = t.CreatedOn.Day
                })
                .ToList()
                .ForEach(t =>
                 {
                     dates.Add(t.Date);
                     transactionAmounts.Add(t.Amount);
                 });

            var jsonStringDay = JsonSerializer.Serialize(dates);
            var jsonStringAmount = JsonSerializer.Serialize(transactionAmounts);

            var modelBudgetViewModel = new BudgetViewModel()
            {
                Balance = budget.Balance,
                MontlyTransactionsAmount = jsonStringAmount,
                MontlyTransactionsDay = jsonStringDay
            };

            return modelBudgetViewModel;
        }
        private void CheckIfNull(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"No {obj.GetType()} found!");
            }
        }
        private void CheckIfAmountIsEqualOrLessThanZero(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentNullException("Amount is invalid!");
            }
        }
    }
}
