using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetApp.ViewModels
{
    public class TransactionViewModel
    {
        public int Id { get; set; }

        public TransactionType Type { get; set; }

        public Currency Currency { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ReccursOn { get; set; }

        public ushort TimesReccuring { get; set; }

        public bool IsReccuring { get; set; }
    }
}
