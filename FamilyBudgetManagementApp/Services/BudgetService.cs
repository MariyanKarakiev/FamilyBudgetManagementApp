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
using Newtonsoft.Json;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public async Task<BudgetViewModel> GetStatistics(DateTime dateFrom, DateTime dateTo)
        {
            var budget = await dbContext.Bugets
                                         .Where(b => b.Id == 1)
                                         .Include(b => b.Transactions)
                                         .FirstOrDefaultAsync();

            CheckIfNull(budget);

            decimal totalIncome = CalculateSum(budget.Transactions.Where(t => t.Type == TransactionType.Income).ToList());
            decimal totalOutcome = CalculateSum(budget.Transactions.Where(t => t.Type == TransactionType.Outcome).ToList());


            (var daysJson, var transactionsJson) = await GetChartData(dateFrom, dateTo, budget);
         

            var modelBudgetViewModel = new BudgetViewModel()
            {
                Balance = CalculateSum(budget.Transactions.ToList()),
                TotalIncome = totalIncome,
                TotalOutcome = totalOutcome < 0 ? totalOutcome * -1 : totalIncome,
                // TotalTransactions = totalIncome - totalOutcome,
                TransactionsJson = JsonConvert.SerializeObject(transactionsJson),
                DaysJson = JsonConvert.SerializeObject(daysJson)
        };

            return modelBudgetViewModel;
        }
        private async Task<(List<string> daysJson, List<decimal> transactionsJson)> GetChartData(DateTime fromDate, DateTime toDate, Budget _budget)
        {
            var dates = new List<string>();
            var transactionAmounts = new List<decimal>();

            Budget budget = new Budget();

            budget.Transactions = _budget.Transactions
                                                  .Where(t => DateTime.Compare(t.CreatedOn, fromDate) >= 0 && DateTime.Compare(t.CreatedOn, toDate) <= 0)
                                                  .OrderBy(t => t.CreatedOn)
                                                  .ToList();

            for (DateTime i = fromDate; i <= toDate; i = i.AddDays(1))
            {

                //TO DO: Transaction is not binded with the date but just with
                //the day(as a number) so when there are 2
                //of the same date the transaction is doubled 13.06, 13.07  

                var sum = CalculateSum(
                        budget.Transactions
                            .Where(t => t.CreatedOn.Date == i.Date)
                            .ToList());

                dates.Add(i.Date.ToString("dd/MM/yyyy"));
                transactionAmounts.Add(sum);
            }

            //var daysJson = JsonConvert.SerializeObject(dates);
            //var transactionsJson = JsonConvert.SerializeObject(transactionAmounts);

            return (dates, transactionAmounts);
        }
        public async Task<(string daysJson, string transactionsJson)> GetChartData(DateTime fromDate, DateTime toDate)
        {
            var dates = new List<string>();
            var transactionAmounts = new List<decimal>();
            Budget budget;

            var _budget = await dbContext.Bugets
                                          .Where(b => b.Id == 1)
                                          .Include(b =>
                                              b.Transactions
                                                      .Where(t => DateTime.Compare(t.CreatedOn, fromDate) >= 0 && DateTime.Compare(t.CreatedOn, toDate) <= 0)
                                                      .OrderBy(t => t.CreatedOn)
                                                  )
                                          .FirstOrDefaultAsync();

            CheckIfNull(_budget);

            budget = _budget;


            for (DateTime i = fromDate; i <= toDate; i = i.AddDays(1))
            {

                //TO DO: Transaction is not binded with the date but just with
                //the day(as a number) so when there are 2
                //of the same date the transaction is doubled 13.06, 13.07  

                var sum = CalculateSum(
                        budget.Transactions
                            .Where(t => t.CreatedOn.Date == i.Date)
                            .ToList());

                dates.Add(i.Date.ToString("dd/MM/yyyy"));
                transactionAmounts.Add(sum);
            }

            var daysJson = JsonConvert.SerializeObject(dates);
            var transactionsJson = JsonConvert.SerializeObject(transactionAmounts);

            return (daysJson, transactionsJson);
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

            return sum = income - outcome;
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
