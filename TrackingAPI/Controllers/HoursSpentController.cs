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
    public class HoursSpentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoursSpentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<HoursSpent> Get() // Need to set so it gets by id
        {
            return _context.HoursSpent.ToList();
        }
    }
}