using FamilyBudgetApp.Data.Enums;
using FamilyBudgetApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetManagementApp.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public TransactionType Type { get; set; }
        public Currency Currency { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ReccursOn { get; set;}
        public ushort TimesReccuring { get; set;}
        public bool IsReccuring { get; set;}

        [Required]
        public byte BudgetId { get; set; }
        public virtual Budget Budget { get; set; }
    }
}