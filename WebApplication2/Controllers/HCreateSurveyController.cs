using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Data.Services;

namespace WebApplication2.Controllers
{

    public class HCreateSurveyController : Controller
    {
        private readonly CreateSurveyService _service;

        public HCreateSurveyController(CreateSurveyService service)
        {
            _service = service;
        }
        public async Task<IActionResult >Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

    }
}
