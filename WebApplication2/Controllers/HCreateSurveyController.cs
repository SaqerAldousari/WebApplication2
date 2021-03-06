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
    public class HCreateSurveyController : Controller
    {
        private readonly AppDbContext _context;

        public HCreateSurveyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allHCreateSurvey = await _context.Survey.ToListAsync();
            return View(allHCreateSurvey);
        }
    }
}
