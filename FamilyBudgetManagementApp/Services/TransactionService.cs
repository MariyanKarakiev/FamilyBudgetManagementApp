using FamilyBudgetApp.Services.Contracts;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using FamilyBudgetApp.Data.Enums;

namespace FamilyBudgetApp.Services
{
    public class TransactionService : ITransactionService
    {
        private AppDbContext dbContext;

        public TransactionService(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task AddTransaction(TransactionViewModel model)
        {
            Transaction transaction = new Transaction
            {
                Amount = model.Amount,
<<<<<<< Updated upstream
                //Do we give the user an option to add Transactions on specific dates?
=======
>>>>>>> Stashed changes
                CreatedOn = DateTime.Now,
                Currency = model.Currency,
                IsReccuring = model.IsReccuring,
                Name = model.Name,
                ReccursOn = model.ReccursOn,
                TimesReccuring = 0,
                Type = model.Type
            };

            await this.dbContext.Transactions.AddAsync(transaction);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await this.dbContext.Transactions.ToListAsync();
        }

<<<<<<< Updated upstream
        //Is it logical to have the ability to Edit a transaction?
        //IsReccuring and ReccursOn are the only two that warant Edit action
        //If Edits to transactions are made, specifically Amount and Type, we need
        //to adjust the Budget as well. Do we do it here or Elsewhere?
        public async Task EditTransaction(TransactionViewModel model)
        {
            Transaction transaction = await this.dbContext.Transactions.FindAsync(model.Id);

            await this.AdjustBalance(model, transaction);

            transaction.Currency = model.Currency;
=======
        public async Task<TransactionViewModel> GetTransaction(int id)
        {
            var transaction = await dbContext.Transactions.FindAsync(id);

            if (transaction != null)
            {
                throw new IndexOutOfRangeException();
            }

            var model = new TransactionViewModel
            {
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
            var transaction = await dbContext.Transactions.FindAsync(model.Id);

            if (transaction != null)
            {
                throw new IndexOutOfRangeException();
            }

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
>>>>>>> Stashed changes
            transaction.Amount = model.Amount;
            transaction.IsReccuring = model.IsReccuring;
            transaction.Name = model.Name;
            transaction.ReccursOn = model.ReccursOn;
            transaction.Type = model.Type;

            this.dbContext.Transactions.Update(transaction);
            await this.dbContext.SaveChangesAsync();
        }


        public async Task DeleteTransaction(TransactionViewModel model)
        {
<<<<<<< Updated upstream
            Transaction transaction = await this.dbContext.Transactions.FindAsync(model.Id);
=======
            var transaction = await dbContext.Transactions.FindAsync(model.Id);

            if (transaction != null)
            {
                throw new IndexOutOfRangeException();
            }
>>>>>>> Stashed changes

            this.dbContext.Transactions.Remove(transaction);
            await this.dbContext.SaveChangesAsync();
        }

<<<<<<< Updated upstream
        private async Task AdjustBalance(TransactionViewModel model, Transaction transaction)
=======

        public async Task TransactOnBudget(Transaction transaction, TransactionViewModel model)
>>>>>>> Stashed changes
        {
            if (transaction.Type == model.Type)
            {
                if (transaction.Type == TransactionType.Income)
                {
                    //var difference = transaction.Amount - model.Amount;
                    //BudgetService budgetService = new BudgetService(this.dbContext);
                    //await budgetService.DischargeBudgetAsync(difference);
                }
            }
        }
    }
}
