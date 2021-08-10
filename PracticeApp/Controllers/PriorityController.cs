using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Controllers
{
    public class PriorityController : Controller
    {
        private readonly ILogger<PriorityController> _logger;

        public PriorityController(ILogger<PriorityController> logger)
        {
            _logger = logger;
        }

        public IActionResult PriorityPath()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
