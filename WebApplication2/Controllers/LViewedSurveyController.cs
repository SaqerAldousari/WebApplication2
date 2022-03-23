using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class LViewedSurveyController : Controller
    {
        private readonly AppDbContext _context;

        public LViewedSurveyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allViewedSurvey = await _context.Survey.ToListAsync();
            return View(allViewedSurvey);
        }
    }
}
