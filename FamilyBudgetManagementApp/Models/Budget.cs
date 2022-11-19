﻿using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetManagementApp.Models
{
    public class Budget
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();

    }
}
