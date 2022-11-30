using FamilyBudgetApp.Services;
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
    }
}
