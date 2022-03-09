using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{

    public class HCreateSurveyController : Controller
    {
        private readonly AppDbContext _context;

        public HCreateSurveyController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Questions.ToList();
            return View();
        }
    }
}
