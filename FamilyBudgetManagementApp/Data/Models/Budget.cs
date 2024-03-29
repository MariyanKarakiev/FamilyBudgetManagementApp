﻿using FamilyBudgetManagementApp.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudgetApp.Data.Models
{
    public class Budget
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
