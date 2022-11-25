using FamilyBudgetManagementApp.Models;
using FamilyBudgetManagementApp.ViewModels;

namespace FamilyBudgetManagementApp.Services.Contracts
{
    public interface IBudgetService
    {
        public Task<BudgetViewModel> GetBudgetInfoForStats();
        public Task ChargeBudget(decimal amount);
        public Task DischargeBudget(decimal amount);
    }
}
