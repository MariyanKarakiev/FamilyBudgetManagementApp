namespace FamilyBudgetManagementApp.ViewModels
{
    public class BudgetViewModel
    {   
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public string MontlyTransactionsAmount { get; set; }
        public string MontlyTransactionsDay { get; set; }

    }
}
