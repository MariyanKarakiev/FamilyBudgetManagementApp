using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Services;
using FamilyBudgetApp.ViewModels;
using FamilyBudgetManagementApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task<IActionResult> Index(int pageNumber, string searchString)
        {
            var model = new List<TransactionViewModel>();

            ViewData["CurrentFilter"] = searchString;
            ViewData["PageNumber"] = pageNumber;

            model = await transactionService.GetPaginatedTransactionsList(pageNumber, 3, searchString);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Types = new SelectList(Enum.GetNames(typeof(TransactionType)).ToList());
            ViewBag.Currency = new SelectList(Enum.GetNames(typeof(Currency)).ToList());

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionViewModel model)
        {
            if (ModelState.IsValid)
            {
                await this.transactionService.AddTransaction(model);
                return Redirect("/");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            ViewBag.Types = new SelectList(Enum.GetNames(typeof(TransactionType)).ToList());
            ViewBag.Currency = new SelectList(Enum.GetNames(typeof(Currency)).ToList());

            return View(await this.transactionService.GetTransaction(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TransactionViewModel model)
        {
            await this.transactionService.EditTransaction(model);

            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            return View(await this.transactionService.GetTransaction(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TransactionViewModel model)
        {
            await this.transactionService.DeleteTransaction(model);

            return Redirect("/");
        }
    }
}
