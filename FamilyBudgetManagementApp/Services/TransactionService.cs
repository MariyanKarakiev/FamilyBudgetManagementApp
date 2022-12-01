using FamilyBudgetApp.Services.Contracts;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetApp.Data.Enums;
using FamilyBudgetManagementApp.Services;

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

            var isCastToEnum = Enum.TryParse<Currency>(model.Currency, true, out Currency currency);

            if (!isCastToEnum)
            {
                throw new InvalidCastException();

            }

            var isCastToEnumType = Enum.TryParse<TransactionType>(model.Type, true, out TransactionType transactionType);

            if (!isCastToEnumType)
            {
                throw new InvalidCastException();

            }

            Transaction transaction = new Transaction
            {
                Amount = model.Amount,
                CreatedOn = DateTime.Now,
                Currency = currency,
                IsReccuring = model.IsReccuring,
                Name = model.Name,
                ReccursOn = model.ReccursOn,
                TimesReccuring = 0,
                Type = transactionType,
                BudgetId = 1
            };

            await TransactOnBudget(transaction, model);
            await dbContext.Transactions.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<TransactionViewModel>> GetAllTransactions()
        {
            var transactions = await dbContext.Transactions.ToListAsync();

            CheckClassIfNull(transactions);

            var models = transactions
                .Select(t => new TransactionViewModel()
                {
                    Id= t.Id,
                    Amount = t.Amount,
                    CreatedOn = t.CreatedOn,
                    Currency = t.Currency.ToString(),
                    IsReccuring = t.IsReccuring,
                    Name = t.Name,
                    ReccursOn = t.ReccursOn,
                    TimesReccuring = t.TimesReccuring,
                    Type = t.Type.ToString()
                })
                .ToList();

            return models;
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
                    Currency = transaction.Currency.ToString(),
                    IsReccuring = transaction.IsReccuring,
                    Name = transaction.Name,
                    ReccursOn = transaction.ReccursOn,
                    TimesReccuring = transaction.TimesReccuring,
                    Type = transaction.Type.ToString()
                };

            return model;
        }

        public async Task EditTransaction(TransactionViewModel model)
        {
            CheckClassIfNull(model);

            Transaction transaction = await dbContext.Transactions.FindAsync(model.Id);

            CheckClassIfNull(transaction);

            var isCastToEnum = Enum.TryParse<Currency>(model.Currency, true, out Currency currency);

            if (!isCastToEnum)
            {
                throw new InvalidCastException();

            }

            var isCastToEnumType = Enum.TryParse<TransactionType>(model.Currency, true, out TransactionType transactionType);

            if (!isCastToEnum)
            {
                throw new InvalidCastException();

            }

            await TransactOnBudget(transaction, model);

            transaction.Currency = currency;
            transaction.Amount = model.Amount;
            transaction.IsReccuring = model.IsReccuring;
            transaction.Name = model.Name;
            transaction.ReccursOn = model.ReccursOn;
            transaction.Type = transactionType;

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

        public async Task TransactOnBudget(Transaction transaction, TransactionViewModel model)
        {
            if (transaction.Amount <= model.Amount)
            {
                await budgetService.DischargeBudgetAsync(model.Amount);
            }
            else
            {
                await budgetService.ChargeBudgetAsync(model.Amount - transaction.Amount);
            }
        }

        public void CheckClassIfNull(object classToCheck)
        {
            if (classToCheck == null)
            {
                throw new ArgumentNullException(classToCheck.GetType().ToString(), "Object was not passed correctly.");
            }
        }
    }
}
