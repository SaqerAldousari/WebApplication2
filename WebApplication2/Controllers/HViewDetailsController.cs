using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class HViewDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public HViewDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Survey.ToList();
            return View(data);
        }
        public IActionResult Index1()
        {
            var data = _context.Survey.ToList();
            return View(data);
        }
        public IActionResult Index2()
        {
            var data = _context.Survey.ToList();
            return View(data);
        }
    }
}
