using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectAPI.Models;
using TrackingAPI.Data;

namespace TrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            List<Project> projects = new List<Project>();
            foreach (Project project in _context.Projects)
            {
                project.Expenses = _context.Expenses.Where(e => e.ProjectId == project.Id).ToList();
                project.HoursSpent = _context.HoursSpent.Where(h => h.ProjectId == project.Id).ToList();
                project.Notes = _context.Notes.Where(n => n.ProjectId == project.Id).ToList();
                project.Receipts = _context.Receipts.Where(r => r.ProjectId == project.Id).ToList();
                projects.Add(project);
            }

            return projects;
        }
    }
}