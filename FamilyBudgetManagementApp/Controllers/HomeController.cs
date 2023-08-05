using FamilyBudgetApp.Common;
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
            //TO DO: Refactor service so that it follows OOP principles. GetStatistics must be more universal and reusable. Must return a more suitable model to be used by 
            return View(await budgetService.GetStatistics(DateTime.Now.AddDays(-7), DateTime.Now));
        }

        [HttpGet]
        public async Task<JsonResult> GetChartData(string periodOfTimeValue)
        {
            PeriodOfTime period = (PeriodOfTime)Enum.Parse(typeof(PeriodOfTime), periodOfTimeValue);
            DateTime dateFrom = new DateTime();
            DateTime dateTo = DateTime.Now;

            switch (period)
            {
                case PeriodOfTime.Week:
                    dateFrom = dateTo.AddDays(-7);
                    break;
                case PeriodOfTime.Month:
                    dateFrom = dateTo.AddMonths(-1);
                    break;
                case PeriodOfTime.Year:
                    dateFrom = dateTo.AddYears(-1);
                    break;
                default:
                    break;
            }

            var data = await budgetService.GetChartData(dateFrom, dateTo);

            return Json(new { data.daysJson, data.transactionsJson });
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