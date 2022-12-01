using FamilyBudgetApp.Services;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetApp.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ILogger<TransactionController> _logger;
        private TransactionService transactionService;

        public TransactionController(ILogger<TransactionController> logger, TransactionService _transactionService)
        {
            _logger = logger;
            transactionService = _transactionService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await transactionService.GetAllTransactions();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionViewModel model)
        {
            await this.transactionService.AddTransaction(model);

            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await this.transactionService.GetTransaction(id));
        }

        [HttpPost]
        [ActionName(nameof(Edit))]
        public async Task<IActionResult> EditConfirm(TransactionViewModel model)
        {
            await this.transactionService.EditTransaction(model);

            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await this.transactionService.GetTransaction(id));
        }

        [HttpPost]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> DeleteConfirm(TransactionViewModel model)
        {
            await this.transactionService.DeleteTransaction(model);

            return Redirect("/");
        }
    }
}
