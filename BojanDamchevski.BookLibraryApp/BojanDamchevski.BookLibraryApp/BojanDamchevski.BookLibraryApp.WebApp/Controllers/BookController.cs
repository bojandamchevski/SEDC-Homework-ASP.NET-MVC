using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;
using BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BojanDamchevski.BookLibraryApp.WebApp.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        private IAuthorService _authorService;
        public BookController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Books";
            List<BookListViewModel> bookListViewModels = _bookService.GetAllBooks();
            return View(bookListViewModels);
        }
        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Book details";
            BookDetailsViewModel bookDetailsViewModel = _bookService.GetBookDetails(id.Value);
            return View(bookDetailsViewModel);
        }
        public IActionResult Create()
        {
            ViewData["Title"] = "Create book";
            AddBookViewModel addBookViewModel = new AddBookViewModel();
            ViewBag.Authors = _authorService.GetAuthorsForDD();
            return View(addBookViewModel);
        }
        [HttpPost]
        public IActionResult Create(AddBookViewModel addBookViewModel)
        {
            _bookService.CreateBook(addBookViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            ViewData["Title"] = "Edit book";
            AddBookViewModel addBookViewModel = _bookService.GetBookForEditing(id.Value);
            ViewBag.Authors = _authorService.GetAuthorsForDD();
            return View(addBookViewModel);
        }
        [HttpPost]
        public IActionResult Edit(AddBookViewModel addBookViewModel)
        {
            _bookService.EditBook(addBookViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            ViewData["Title"] = "Delete book";
            AddBookViewModel addBookViewModel = _bookService.GetBookForEditing(id.Value);
            return View(addBookViewModel);
        }
        [HttpPost]
        public IActionResult Delete(AddBookViewModel addBookViewModel)
        {
            _bookService.DeleteBook(addBookViewModel.NewId);
            return RedirectToAction("Index");
        }
    }
}
