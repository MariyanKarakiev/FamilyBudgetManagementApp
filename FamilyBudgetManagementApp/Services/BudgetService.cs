using FamilyBudgetApp.Data.Models;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services.Contracts;
using FamilyBudgetManagementApp.ViewModels;
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

        public async Task ChargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfBudgetIsNull(budget);

            budget.Balance += amount;

            dbContext.SaveChanges();
        }

        public async Task DischargeBudgetAsync(decimal amount)
        {
            CheckIfAmountIsEqualOrLessThanZero(amount);

            var budget = await dbContext.FindAsync<Budget>((byte)1);

            CheckIfBudgetIsNull(budget);

            if (budget.Balance-amount<0)
            {
                throw new ArgumentException("Out of funds!");
            }
            budget.Balance -= amount;

            dbContext.SaveChanges();
        }

        private void CheckIfBudgetIsNull(Budget? budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException("No budget found!");
            }
        }
        private void CheckIfAmountIsEqualOrLessThanZero(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentNullException("Amount is invalid!");
            }
        }
    }
}
