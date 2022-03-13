using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class HShowSurveyController : Controller
    {
        private readonly AppDbContext _context;

        public HShowSurveyController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Survey.ToList();
            return View(data);
        }
    }
}
