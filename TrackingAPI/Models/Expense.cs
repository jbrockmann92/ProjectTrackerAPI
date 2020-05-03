using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Cost { get; set; }
    }
}
