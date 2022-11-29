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
                //Do we give the user an option to add Transactions on specific dates?
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

        //Is it logical to have the ability to Edit a transaction?
        //IsReccuring and ReccursOn are the only two that warant Edit action
        //If Edits to transactions are made, specifically Amount and Type, we need
        //to adjust the Budget as well. Do we do it here or Elsewhere?
        public async Task EditTransaction(TransactionViewModel model)
        {
            Transaction transaction = await this.dbContext.Transactions.FindAsync(model.Id);

            await this.AdjustBalance(model, transaction);

            transaction.Currency = model.Currency;
            transaction.Amount = model.Amount;
            transaction.IsReccuring = model.IsReccuring;
            transaction.Name = model.Name;
            transaction.ReccursOn = model.ReccursOn;
            transaction.Type = model.Type;

            this.dbContext.Transactions.Update(transaction);
            await this.dbContext.SaveChangesAsync();
        }


        public async Task DeteleTransaction(TransactionViewModel model)
        {
            Transaction transaction = await this.dbContext.Transactions.FindAsync(model.Id);

            this.dbContext.Transactions.Remove(transaction);
            await this.dbContext.SaveChangesAsync();
        }

        private async Task AdjustBalance(TransactionViewModel model, Transaction transaction)
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
