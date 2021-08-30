using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BojanDamchevski.BookLibraryApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookService _bookService;
        private IMemberService _memberService;
        private IAuthorService _authorService;
        public HomeController(ILogger<HomeController> logger, IBookService bookService, IMemberService memberService, IAuthorService authorService)
        {
            _logger = logger;
            _bookService = bookService;
            _memberService = memberService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            ViewBag.NumberOfBooks = _bookService.GetAllBooks().Count();
            ViewBag.NumberOfMembers = _memberService.GetAllMembers().Count();
            ViewBag.NumberOfAuthors = _authorService.GetAuthorsForDD().Count();
            return View();
        }

        public IActionResult Privacy()
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
