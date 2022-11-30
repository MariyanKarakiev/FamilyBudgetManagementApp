using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetManagementApp.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public Currency Currency { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime ReccursOn { get; set;}

        public ushort TimesReccuring { get; set;}

        [Required]
        public bool IsReccuring { get; set;}

        [Required]
        public byte BudgetId { get; set; }
        public virtual Budget Budget { get; set; }
    }
}