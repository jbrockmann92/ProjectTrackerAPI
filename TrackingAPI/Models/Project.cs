using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Mileage { get; set; }
        public float Budget { get; set; }
        public float BudgetUsed { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<HoursSpent> HoursSpent { get; set; }
        public List<Receipt> Receipts { get; set; }
        public List<Note> Notes { get; set; }
    }
}
