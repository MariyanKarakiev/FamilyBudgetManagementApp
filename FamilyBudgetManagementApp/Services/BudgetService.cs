using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Models;
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

            var budget = await dbContext.Bugets
                .Where(b => b.Id == 1)
                .Include(b =>
                    b.Transactions
                        .Where(t => t.CreatedOn.Month == DateTime.Now.Month)
                        .OrderBy(t => t.CreatedOn)
                        )
                .FirstOrDefaultAsync();

            budget.Balance = CalculateSum(budget.Transactions.ToList());

            CheckIfNull(budget);

            var dates = new List<int>();
            var transactionAmounts = new List<decimal>();

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                var sum = CalculateSum(
                        budget.Transactions
                            .Where(t => t.CreatedOn.Day == i)
                            .ToList());

                dates.Add(i);
                transactionAmounts.Add(sum);
            }

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

        private decimal CalculateSum(List<Transaction> transactions)
        {
            decimal sum = 0M;

            var income = transactions
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);
            var outcome = transactions
                .Where(t => t.Type == TransactionType.Outcome)
                .Sum(t => t.Amount);

            return sum = income + outcome;
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
