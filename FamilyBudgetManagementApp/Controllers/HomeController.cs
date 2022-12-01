using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Services;
using FamilyBudgetManagementApp.Models;
using FamilyBudgetManagementApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FamilyBudgetManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BudgetService budgetService;


        public HomeController(ILogger<HomeController> logger, BudgetService _budgetService)
        {
            _logger = logger;
            budgetService = _budgetService;
        }

        public async Task<IActionResult> Index()
        {        
           
            return View(await budgetService.GetStatistics());
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