using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectAPI.Models;
using TrackingAPI.Data;

namespace TrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpensesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Expense> Get() // Need to set so it gets by id
        {
            return _context.Expenses.ToList();
        }
    }
}