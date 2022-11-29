using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Models;

namespace FamilyBudgetApp.Services.Contracts
{
    public interface ITransactionService
    {
        public Task AddTransaction(TransactionViewModel model);

        public Task<List<Transaction>> GetAllTransactions();

        public Task EditTransaction(TransactionViewModel model);

        public Task DeteleTransaction(TransactionViewModel model);

        Task AdjustBalance(TransactionViewModel model, Transaction transaction);
    }
}
