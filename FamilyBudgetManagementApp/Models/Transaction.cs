using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetManagementApp.Models
{
    public class Transaction
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        public Enum Type { get; set; }

        [Required]
        public Enum Currency { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ReccursOn { get; set;}

        [Required]
        public ushort TimesReccuring { get; set;}

        [Required]
        public bool IsReccuring { get; set;}
    }
}