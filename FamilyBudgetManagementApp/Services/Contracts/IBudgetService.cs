using FamilyBudgetManagementApp.Models;
using FamilyBudgetManagementApp.ViewModels;

namespace FamilyBudgetManagementApp.Services.Contracts
{
    public interface IBudgetService
    {
        public Task<BudgetViewModel> GetStatistics();
        public Task ChargeBudgetAsync(decimal amount);
        public Task DischargeBudgetAsync(decimal amount);
    }
}
