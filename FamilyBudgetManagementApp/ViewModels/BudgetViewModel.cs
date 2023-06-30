namespace FamilyBudgetManagementApp.ViewModels
{
    public class BudgetViewModel
    {   
        public int Id { get; set; }

        public decimal Balance { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalOutcome { get; set; }
        public decimal TotalTransactions { get; set; }

        public string TransactionsAmountJson { get; set; }
        public string DaysJson { get; set; }

    }
}
