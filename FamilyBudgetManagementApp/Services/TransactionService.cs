using FamilyBudgetApp.Services.Contracts;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetApp.Data.Enums;
using FamilyBudgetManagementApp.Services;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FamilyBudgetApp.Services
{
    public class TransactionService : ITransactionService
    {
        private AppDbContext dbContext;
        private BudgetService budgetService;

        public TransactionService(AppDbContext _dbContext, BudgetService _budgetService)
        {
            dbContext = _dbContext;
            budgetService = _budgetService;
        }

        public async Task AddTransaction(TransactionViewModel model)
        {
            Transaction transaction = new Transaction
            {
                Amount = model.Amount,
                CreatedOn = DateTime.Now,
                Currency = model.Currency,
                IsReccuring = model.IsReccuring,
                Name = model.Name,
                ReccursOn = (DateTime)model.ReccursOn,
                TimesReccuring = 0,
                Type = model.Type,
                BudgetId = 1
            };

            await TransactOnBudget(transaction);
            await dbContext.Transactions.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<TransactionViewModel>> GetAllTransactions()
        {
            var transactions = await dbContext.Transactions
                .OrderByDescending(t => t.CreatedOn)
                .ToListAsync();

            CheckClassIfNull(transactions);

            var models = transactions
                .Select(t => new TransactionViewModel()
                {
                    Id = t.Id,
                    Amount = t.Amount,
                    CreatedOn = t.CreatedOn,
                    Currency = t.Currency,
                    IsReccuring = t.IsReccuring,
                    Name = t.Name,
                    ReccursOn = t.ReccursOn,
                    TimesReccuring = t.TimesReccuring,
                    Type = t.Type
                })
                .ToList();

            return models;
        }
        public async Task<List<TransactionViewModel>> GetAllTransactions(string searchParameter)
        {

            var transactions = await dbContext.Transactions
                .OrderByDescending(t => t.CreatedOn)
                .ToListAsync();

            CheckClassIfNull(transactions);

            Regex regex = new Regex(searchParameter, RegexOptions.IgnoreCase);
            var matchingTransactions = new List<TransactionViewModel>();

            foreach (var transaction in transactions)
            {
                if (regex.IsMatch(transaction.Name))
                {
                    matchingTransactions.Add(
                        new TransactionViewModel()
                        {
                            Id = transaction.Id,
                            Amount = transaction.Amount,
                            CreatedOn = transaction.CreatedOn,
                            Currency = transaction.Currency,
                            IsReccuring = transaction.IsReccuring,
                            Name = transaction.Name,
                            ReccursOn = transaction.ReccursOn,
                            TimesReccuring = transaction.TimesReccuring,
                            Type = transaction.Type
                        });
                }
            }

            return matchingTransactions;
        }

        public async Task<TransactionViewModel> GetTransaction(Guid id)
        {
            var transaction = await dbContext.Transactions.FindAsync(id);

            CheckClassIfNull(transaction);

            var model = new TransactionViewModel
            {
                Id = transaction.Id,
                Amount = transaction.Amount,
                CreatedOn = transaction.CreatedOn,
                Currency = transaction.Currency,
                IsReccuring = transaction.IsReccuring,
                Name = transaction.Name,
                ReccursOn = transaction.ReccursOn,
                TimesReccuring = transaction.TimesReccuring,
                Type = transaction.Type
            };

            return model;
        }

        public async Task EditTransaction(TransactionViewModel model)
        {
            CheckClassIfNull(model);

            Transaction transaction = await dbContext.Transactions.FindAsync(model.Id);

            CheckClassIfNull(transaction);

            transaction.Currency = model.Currency;
            transaction.Amount = model.Amount;
            transaction.IsReccuring = model.IsReccuring;
            transaction.Name = model.Name;
            transaction.ReccursOn = model.ReccursOn;
            transaction.Type = model.Type;

            await TransactOnBudget(transaction);
            dbContext.Transactions.Update(transaction);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteTransaction(TransactionViewModel model)
        {
            CheckClassIfNull(model);

            Transaction transaction = await dbContext.Transactions.FindAsync(model.Id);

            CheckClassIfNull(transaction);

            dbContext.Transactions.Remove(transaction);
            await dbContext.SaveChangesAsync();
        }

        public async Task TransactOnBudget(Transaction model)
        {
            if (model.Type == TransactionType.Outcome)
            {
                await budgetService.DischargeBudgetAsync(model.Amount);
            }
            else if (model.Type == TransactionType.Income)
            {
                await budgetService.ChargeBudgetAsync(model.Amount);
            }
        }

        public void CheckClassIfNull(object classToCheck)
        {
            if (classToCheck == null)
            {
                throw new ArgumentNullException(classToCheck.GetType().ToString(), "Object was not passed correctly.");
            }
        }

        public TransactionViewModel CheckReccursIfNull(TransactionViewModel model)
        {
            if (model.ReccursOn == null)
            {
                model.ReccursOn = DateTime.Now;
            }

            return model;
        }
    }
}
