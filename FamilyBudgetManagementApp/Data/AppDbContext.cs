﻿using FamilyBudgetManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetManagementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Budget> Bugets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}