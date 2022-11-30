using FamilyBudgetApp.Services;
using FamilyBudgetManagementApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FamilyBudgetManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TransactionService transactionService;

        public HomeController(ILogger<HomeController> logger, TransactionService _transactionService)
        {
            _logger = logger;
            transactionService = _transactionService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await transactionService.GetAllTransactions();

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}