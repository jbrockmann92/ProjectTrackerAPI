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
                    new HoursSpent { Id = 1, Name = "Jacob", Hours = 5, ProjectId = 1},
                    new HoursSpent { Id = 2, Name = "Joey", Hours = 15, ProjectId = 1},
                    new HoursSpent { Id = 3, Name = "Fleck", Hours = 5, ProjectId = 2 },
                    new HoursSpent { Id = 4, Name = "Caleb", Hours = 15, ProjectId = 2 }
                    );
            builder.Entity<Note>().HasData(
                    new Note { Id = 1, Title = "New Note", Text = "This one is good", ProjectId = 1},
                    new Note { Id = 2, Title = "Receipt Note", Text = "This is good too", ProjectId = 1 }
                    );
            builder.Entity<Expense>().HasData(
                    new Expense { Id = 1, Title = "Shingles", Cost = 25, ProjectId = 1 },
                    new Expense { Id = 2, Title = "Nail Gun", Cost = 125, ProjectId = 1 },
                    new Expense { Id = 3, Title = "Underlayment", Cost = 25, ProjectId = 2 }
                    );
            builder.Entity<Project>().HasData(
                    new Project { Id = 1, Title = "Roof", Mileage = 45, Budget = 5000, BudgetUsed = 1300},
                    new Project { Id = 2, Title = "Janesville House", Mileage = 134, Budget = 3500, BudgetUsed = 2200}
                    );
            builder.Entity<Receipt>().HasData(
                    new Receipt { Id = 1, Store = "Menards", Total = 100, ProjectId = 1 },
                    new Receipt { Id = 2, Store = "Menards", Total = 50, ProjectId = 2 }

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
