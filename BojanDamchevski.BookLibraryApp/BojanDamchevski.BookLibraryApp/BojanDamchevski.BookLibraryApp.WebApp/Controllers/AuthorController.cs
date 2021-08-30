using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BojanDamchevski.BookLibraryApp.WebApp.Controllers
{
    public class AuthorController : Controller
    {
        private IBookService _bookService;
        private IAuthorService _authorService;
        public AuthorController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            List<AuthorDDViewModel> authorDDViewModels = _authorService.GetAuthorsForDD();
            ViewData["Title"] = "Authors"; 
            return View(authorDDViewModels);
        }
        public IActionResult Details(int? id)
        {
            AuthorDetailsViewModel authorDetailsViewModel = _authorService.GetAuthorBooks(id.Value);
            ViewData["Title"] = "Author details"; 
            return View(authorDetailsViewModel);
        }
        public IActionResult Create()
        {
            ViewData["Title"] = "Create author"; 
            AddAuthorViewModel addAuthorViewModel = new AddAuthorViewModel();
            return View(addAuthorViewModel);
        }
        [HttpPost]
        public IActionResult Create(AddAuthorViewModel addAuthorViewModel)
        {
            _authorService.CreateAuthor(addAuthorViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            ViewData["Title"] = "Edit author";
            AddAuthorViewModel authorDetailsViewModel = _authorService.GetAuthorForEditing(id.Value);
            return View(authorDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Edit(AddAuthorViewModel authorDetailsViewModel)
        {
            _authorService.EditAuthor(authorDetailsViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            ViewData["Title"] = "Delete author";
            AddAuthorViewModel authorDetailsViewModel = _authorService.GetAuthorForEditing(id.Value);
            return View(authorDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Delete(AddAuthorViewModel authorDetailsViewModel)
        {
            _authorService.DeleteAuthor(authorDetailsViewModel.NewId);
            return RedirectToAction("Index");
        }
    }
}
