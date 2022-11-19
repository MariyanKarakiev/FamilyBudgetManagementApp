using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetManagementApp.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
    }
}