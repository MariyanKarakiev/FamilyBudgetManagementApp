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

            var isCastToEnumType = Enum.TryParse<TransactionType>(model.Currency, true, out TransactionType transactionType);

            if (!isCastToEnum)
            {
                throw new InvalidCastException();

            }

            Transaction transaction = new Transaction
            {
                Amount = model.Amount,
                //Do we give the user an option to add Transactions on specific dates? Nope
                CreatedOn = DateTime.Now,
                Currency = currency,
                IsReccuring = model.IsReccuring,
                Name = model.Name,
                ReccursOn = model.ReccursOn,
                TimesReccuring = 0,
                Type = transactionType
            };

            await TransactOnBudget(transaction, model);
            await dbContext.Transactions.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
        }



        public async Task<List<TransactionViewModel>> GetAllTransactions()
        {
            var transactions = await dbContext.Transactions.ToListAsync();

            var models = transactions
                .Select(t => new TransactionViewModel()
                {
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

        //Is it logical to have the ability to Edit a transaction?
        //IsReccuring and ReccursOn are the only two that warant Edit action
        //If Edits to transactions are made, specifically Amount and Type, we need
        //to adjust the Budget as well. Do we do it here or Elsewhere?

        // we have to inject budget service into transaction service and then use budgetService.ChargeBalance() : Done
        public async Task EditTransaction(TransactionViewModel model)
        {
            Transaction transaction = await dbContext.Transactions.FindAsync(model.Id);

            //check if transaction is null
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


            //charging and discharging budget, transaction should`t change the budget directly
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


        public async Task DeteleTransaction(TransactionViewModel model)
        {
            Transaction transaction = await dbContext.Transactions.FindAsync(model.Id);

            //check if transaction is null

            dbContext.Transactions.Remove(transaction);
            await dbContext.SaveChangesAsync();
        }

        //bez da iskam ti iztrih methoda sorry
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
    }
}
