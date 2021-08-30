using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BojanDamchevski.BookLibraryApp.WebApp.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;
        private IBookService _bookService;
        public MemberController(IMemberService memberService, IBookService bookService)
        {
            _memberService = memberService;
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Members";
            List<MemberListViewModel> memberListViewModels = _memberService.GetAllMembers();
            return View(memberListViewModels);
        }
        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Member details";
            MemberDetailsViewModel memberDetailsViewModel = _memberService.GetMemberDetails(id.Value);
            return View(memberDetailsViewModel);
        }
        public IActionResult Create()
        {
            ViewData["Title"] = "Create member";
            AddMemberViewModel addMemberViewModel = new AddMemberViewModel();
            return View(addMemberViewModel);
        }
        [HttpPost]
        public IActionResult Create(AddMemberViewModel addMemberViewModel)
        {
            _memberService.CreateNewMember(addMemberViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult AddBookAndReservation(int id)
        {
            ViewData["Title"] = "Add book";
            MemberBookReservationViewModel memberBookReservationViewModel = new MemberBookReservationViewModel();
            memberBookReservationViewModel.MemberId = id;
            ViewBag.Books = _bookService.GetAllBooks();
            return View(memberBookReservationViewModel);
        }
        [HttpPost]
        public IActionResult AddBookAndReservation(MemberBookReservationViewModel memberBookReservationViewModel)
        {
            _memberService.AddBook(memberBookReservationViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBookAndReservation(int id)
        {
            MemberDetailsViewModel memberDetailsViewModel = _memberService.GetMemberDetails(id);
            ViewBag.BookReservations = _memberService.GetBookReservationsDD(id);
            return View(memberDetailsViewModel);
        }
        [HttpPost]
        public IActionResult DeleteBookAndReservation(MemberDetailsViewModel memberDetailsViewModel)
        {
            ViewData["Title"] = "Delete book";
            _memberService.DeteleBookAndReservation(memberDetailsViewModel.DeleteReservationId, memberDetailsViewModel.Id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Edit member";
            AddMemberViewModel addMemberViewModel = _memberService.GetMemberForEditing(id);
            return View(addMemberViewModel);
        }
        [HttpPost]
        public IActionResult Edit(AddMemberViewModel addMemberViewModel)
        {
            _memberService.EditMember(addMemberViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            ViewData["Title"] = "Delete member";
            AddMemberViewModel addMemberViewModel = _memberService.GetMemberForEditing(id.Value);
            return View(addMemberViewModel);
        }
        [HttpPost]
        public IActionResult Delete(AddMemberViewModel addMemberViewModel)
        {
            _memberService.DeleteMember(addMemberViewModel.NewId);
            return RedirectToAction("Index");
        }
    }
}
