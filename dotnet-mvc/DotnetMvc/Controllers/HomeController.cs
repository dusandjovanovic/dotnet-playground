using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetMvc.Models;
using DotnetMvc.Filters;

namespace DotnetMvc.Controllers
{
    [TypeFilter(typeof(OutageAuthorizationFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [MobileRedirectActionFilter(Action = "Data", Controller = "HomeController")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/contact-us", Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("/contact-us", Name = "Contact")]
        public IActionResult Contact([FromForm]Contact info)
        {
            return View();
        }

        [HttpPost]
        [Route("/data", Name = "Data")]
        public IActionResult Data(List<Order> orders)
        {
            return Content("Custom ModelBinder");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Contact
    {
        public string Name { get; set; }

        public string Message { get; set; }
    }

    public class Order
    {
        public string ProductName { get; set; }

        public string Count { get; set; }

        public string Description { get; set; }
    }
}