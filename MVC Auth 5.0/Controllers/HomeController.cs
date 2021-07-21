using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MVC_Auth_5._0.Models;

namespace MVC_Auth_5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmailOptions _emailOptions;

        public HomeController(ILogger<HomeController> logger, IOptions<EmailOptions> emailOptions)
        {
            _logger = logger;
            _emailOptions = emailOptions.Value;
        }

        public IActionResult Index()
        {
            ViewBag.EmailOptions = _emailOptions;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}