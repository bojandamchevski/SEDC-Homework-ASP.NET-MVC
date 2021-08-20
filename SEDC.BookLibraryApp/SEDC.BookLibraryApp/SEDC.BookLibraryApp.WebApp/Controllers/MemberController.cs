using Microsoft.AspNetCore.Mvc;
using SEDC.BookLibraryApp.Services.Implementations;
using SEDC.BookLibraryApp.Services.Interfaces;
using SEDC.BookLibraryApp.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.BookLibraryApp.WebApp.Controllers
{
    public class MemberController : Controller
    {
        public IMemberService _memberService;
        public MemberController()
        {
            _memberService = new MemberService();
        }
        public IActionResult Index()
        {
            List<MemberViewModel> memberViewModels = _memberService.GetAllMembers();
            return View(memberViewModels);
        }
    }
}
