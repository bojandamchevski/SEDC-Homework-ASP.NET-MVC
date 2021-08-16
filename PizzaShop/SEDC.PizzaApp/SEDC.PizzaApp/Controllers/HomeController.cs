using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("ContactUs")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("AboutUs")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult ReturnAnotherView()
        {
            return View("NewView");
        }

        public IActionResult Users()
        {
            List<UserDetailsViewModel> userDetailsViewModels = StaticDb.Users
                .Select(u => u.UserToUserDetailsViewModel(u))
                .ToList();
            ViewBag.Users = userDetailsViewModels;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
