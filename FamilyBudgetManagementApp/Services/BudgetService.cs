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

        public async Task<BudgetViewModel> GetBudgetInfoForStats()
        {
            // TO DO: return some info for statistics
            var budget = await dbContext.FindAsync<Budget>(1);

            CheckIfBudgetIsNull(budget);

            var model = new BudgetViewModel()
            {
                Id = 1,
                Balance = budget.Balance
            };

            return new BudgetViewModel();
        }

        public async Task ChargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfBudgetIsNull(budget);

            budget.Balance += amount;

            dbContext.SaveChanges();
        }

        public async Task DischargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfBudgetIsNull(budget);

            if (budget.Balance - amount < 0)
            {
                throw new ArgumentException("Out of funds!");
            }
            budget.Balance -= amount;

            dbContext.SaveChanges();
        }
        public async Task<BudgetViewModel> GetStatistics()
        {
            var budget = await dbContext.FindAsync<Budget>(1);

            CheckIfBudgetIsNull(budget);

            var model = new BudgetViewModel()
            {
                Balance = budget.Balance

            };


            var dates = new List<int>();
            var tAmounts = new List<decimal>();

            var obj = await dbContext.Transactions.Select(t => new
            {
                Amount = t.Amount,
                Date = t.CreatedOn.Day

            }).ToListAsync();

            foreach (var t in obj)
            {
                dates.Add(t.Date);
                tAmounts.Add(t.Amount);
            }

            var model = new StatisticsObject()
            {
                MontlyTransactionsAmount = tAmounts,
                MontlyTransactionsDay = dates
            };

            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };

            var jsonStringAmount = JsonSerializer.Serialize(model.MontlyTransactionsAmount, options);
            var jsonStringDay = JsonSerializer.Serialize(model.MontlyTransactionsDay, options);

            // JsonStatsWrite(model, "C:\\Users\\mariq\\Source\\Repos\\MariyanKarakiev\\FamilyBudgetManagementApp-\\FamilyBudgetManagementApp\\Common\\Statistics.json");

            var modelBudgetViewModel = new BudgetViewModel()
            {
                MontlyTransactionsAmount = jsonStringAmount,
                MontlyTransactionsDay = jsonStringDay
            };

            return modelBudgetViewModel;
        }
        private void CheckIfBudgetIsNull(Budget? budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException("No budget found!");
            }
        }
        private void CheckIfAmountIsEqualOrLessThanZero(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentNullException("Amount is invalid!");
            }
        }

        public static void JsonStatsWrite(StatisticsObject obj, string fileName)
        {
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(obj, options);

            File.WriteAllText(fileName, jsonString);
        }
    }
}
