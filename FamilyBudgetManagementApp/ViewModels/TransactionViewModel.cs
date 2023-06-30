using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetApp.ViewModels
{
    public class TransactionViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Amount cannot be 0 or nothing!")]
        [Range(0.01, 9999999)]
        public decimal Amount { get; set; }

        [Required]
        public Currency Currency { get; set; }
      
        [Required]
        public TransactionType Type { get; set; }

        [Required(ErrorMessage = "Please select name for transaction.")]
        public string Name { get; set; } 
        
        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime ReccursOn { get; set; }

        [Required]
        public ushort TimesReccuring { get; set; }

        [Required]
        public bool IsReccuring { get; set; }

        public byte BudgetId { get; set; }
    }
}
