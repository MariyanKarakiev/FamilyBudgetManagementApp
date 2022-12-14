using FamilyBudgetApp.Data.Models;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services;
using Microsoft.EntityFrameworkCore;


namespace FamilyBudgetApp.Tests
{
    public class BudgetServiceTest
    {
        DbContextOptions<AppDbContext> options;
        AppDbContext dbContext;
        
        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestBudgetDB")
                .Options;         
            dbContext = new AppDbContext(options);

            var data = new List<Budget>()
                {
                    new Budget() { Id = 1 },
                    new Budget() { Id = 2 },
                    new Budget() { Id = 3 }
                };

            dbContext.Bugets.AddRange(data);
        }

        [TearDown]
        public void Teardown()
        {
            dbContext.Database.EnsureDeleted();
        }
        //ChargeBalance
        [Test]
        public async Task Method_ChargeBalance_ThrowsException_AmountEqualOrLessThanZero()
        {
            var budgetService = new BudgetService(dbContext);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async () => await budgetService.ChargeBudgetAsync(-1));

                Assert.AreEqual(ex.ParamName, "Amount is invalid!");               
        }
        [Test]
        public void Method_ChargeBalance_ThrowsException_NoBudget() 
        {
            var budgetService = new BudgetService(dbContext);
          
            var budgetDelete = dbContext.Bugets.Find((byte)1);       
            dbContext.Bugets.Remove(budgetDelete);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async () => await budgetService.ChargeBudgetAsync(10));
             
            Assert.AreEqual(ex.ParamName, "No budget found!");   
        }
        [Test]
        public async Task Method_Charges_Balance()
        {
            var budgetService = new BudgetService(dbContext);
            await budgetService.ChargeBudgetAsync(23.34m);

            var dischargedBudget = await dbContext.Bugets.FirstOrDefaultAsync();

            Assert.That(dischargedBudget.Balance, Is.EqualTo(23.34m));
        }

        //DichargeBalance
        [Test]
        public async Task Method_DischargeBalance_ThrowsException_AmountEqualOrLessThanZero()
        {
            using (var dbContext = new AppDbContext(options))
            {
                dbContext.Bugets.Add(new Budget() { Id = 1 });

                var budgetService = new BudgetService(dbContext);

                var ex = Assert.ThrowsAsync<ArgumentNullException>(async () => await budgetService.DischargeBudgetAsync(-10));

                Assert.AreEqual(ex.ParamName, "Amount is invalid!");
            }
        }
        [Test]
        public async Task Method_Discharges_Balance()
        {
            var budgetService = new BudgetService(dbContext);

            dbContext.Remove(budgetService);

            await budgetService.DischargeBudgetAsync(23.34m);

            var dischargedBudget2 = dbContext.Bugets.Find((byte)1);

            Assert.That(dischargedBudget2.Balance, Is.EqualTo(0.66m));
        }

        [Test]
        public void Method_DischargeBalance_ThrowsException_NoBudget()
        {
            var budgetService = new BudgetService(dbContext);

            var budgetDelete = dbContext.Bugets.Find((byte)1);
            dbContext.Bugets.Remove(budgetDelete);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async () => await budgetService.DischargeBudgetAsync(10));

            Assert.AreEqual(ex.ParamName, "No budget found!");
        }
    }
}