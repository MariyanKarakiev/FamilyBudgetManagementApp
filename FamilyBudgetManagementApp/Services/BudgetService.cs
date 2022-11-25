using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Models;
using FamilyBudgetManagementApp.Services.Contracts;
using FamilyBudgetManagementApp.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetManagementApp.Services
{
    public class BudgetService : IBudgetService
    {
        private AppDbContext dbContext;

        public BudgetService(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<BudgetViewModel> GetBudgetInfoForStats()
        {
            // TO DO: return some info for statistics
            var budget = await dbContext.FindAsync<Budget>(1);

            CheckIfBudgetIsNull(budget);

            var model = new BudgetViewModel()
            {
                Id = 1,
                Balance = budget.Balance
            };

            return new BudgetViewModel();
        }

        public async Task ChargeBudget(decimal amount)
        {
            if (amount == 0 || amount < 0)
            {
                return;
            }

            var budget = await dbContext.FindAsync<Budget>(1);

            CheckIfBudgetIsNull(budget);

            budget.Balance += amount;

            dbContext.SaveChanges();
        }

        public async Task DischargeBudget(decimal amount)
        {
            if (amount == 0 || amount < 0)
            {
                return;
            }

            var budget = await dbContext.FindAsync<Budget>(1);

            CheckIfBudgetIsNull(budget);

            //check if < 0
            budget.Balance -= amount;

            dbContext.SaveChanges();
        }

        private void CheckIfBudgetIsNull(Budget ?budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException("No budget found!");
            }
        }
    }
}
