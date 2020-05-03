using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using TrackingAPI.Models;

namespace TrackingAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<HoursSpent>().HasData(
                    new HoursSpent { Id = 1, Name = "Jacob", Hours = 5 }

                    );
            builder.Entity<Note>().HasData(
                    new Note { Id = 1, Title = "New Note", Text = "This one is good" },
                    new Note { Id = 2, Title = "Receipt Note", Text = "This is good too" }
                    );
            builder.Entity<Expense>().HasData(
                    new Expense { Id = 1, Title = "Shingles", Cost = 25 }
                    );
            builder.Entity<Project>().HasData(
                    new Project { Id = 1, Title = "Roof", Mileage = 45, Budget = 5000, BudgetUsed = 1300, ExpenseId = 1, HoursSpentId = 1, ReceiptId = 1, NoteId = 1 }
                    );
            builder.Entity<Receipt>().HasData(
                    new Receipt { Id = 1, Store = "Menards", Total = 100 }
                    );
            ;
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<HoursSpent> HoursSpent { get; set; }

        public DbSet<Receipt> Receipts { get; set; }
    }
}
