using FamilyBudgetManagementApp.Models;
using FamilyBudgetManagementApp.ViewModels;

namespace FamilyBudgetManagementApp.Services.Contracts
{
    public interface IBudgetService
    {
        public Task<BudgetViewModel> GetBudgetInfoForStats();
        public Task ChargeBudgetAsync(decimal amount);
        public Task DischargeBudgetAsync(decimal amount);
    }
}
