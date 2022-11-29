using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetApp.ViewModels
{
    public class TransactionViewModel
    {
        public byte Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }
      
        [Required]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Amount { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ReccursOn { get; set; }

        [Required]
        public ushort TimesReccuring { get; set; }

        [Required]
        public bool IsReccuring { get; set; }

        public byte BudgetId { get; set; }
    }
}
