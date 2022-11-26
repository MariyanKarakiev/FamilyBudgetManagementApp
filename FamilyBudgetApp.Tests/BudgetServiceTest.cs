using FamilyBudgetApp.Data.Models;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services;
using Microsoft.EntityFrameworkCore;
using Moq;



namespace FamilyBudgetApp.Tests
{
    public class BudgetServiceTest
    {
        DbContextOptions<AppDbContext> options;

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestBudgetDB")
                .Options;
        }

        [Test]
        public async Task Method_ChargeBalance_ThrowsException_AmountEqualOrLessThanZero()
        {
            using (var mockContext = new AppDbContext(options))
            {
                mockContext.Bugets.Add(new Budget() { Id = 13 });

                var budgetService = new BudgetService(mockContext);

                Assert.ThrowsAsync<ArgumentNullException>(async () => await budgetService.ChargeBudgetAsync(-1))
            }
        }

        [Test]
        public async Task Method_Charges_Balance()
        {

            using (var mockContext = new AppDbContext(options))
            {
                var data = new List<Budget>()
                {
                    new Budget() { Id = 1 },
                    new Budget() { Id = 2 },
                    new Budget() { Id = 3 }
                };

                mockContext.Bugets.AddRange(data);


                var budgetService = new BudgetService(mockContext);
                await budgetService.ChargeBudgetAsync(23.34m);

                var chargedBudget = await mockContext.Bugets.FirstOrDefaultAsync();

                Assert.That(chargedBudget.Balance, Is.EqualTo(23.34m));
            }
        }
    }
}