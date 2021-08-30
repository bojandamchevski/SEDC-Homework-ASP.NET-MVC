using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackService _feedbackService;
        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }
        public IActionResult Index()
        {
            List<FeedbackListViewModel> feedbackListViewModels = _feedbackService.GetAllFeedbacks();
            return View(feedbackListViewModels);
        }
        public IActionResult Details(int? id)
        {
            FeedbackDetailsViewModel feedbackDetailsViewModel = _feedbackService.GetFeedbackDetails(id.Value);
            return View(feedbackDetailsViewModel);
        }
        public IActionResult SendFeedback()
        {
            FeedbackDetailsViewModel feedbackDetailsViewModel = new FeedbackDetailsViewModel();
            return View(feedbackDetailsViewModel);
        }
        [HttpPost]
        public IActionResult SendFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            if (_feedbackService.CheckFeedbacksLimit(feedbackDetailsViewModel))
            {
                _feedbackService.AddFeedback(feedbackDetailsViewModel);
            }
            else
            {
                throw new Exception("Only 3 feedback allowed per E-mail");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            FeedbackDetailsViewModel feedbackDetailsViewModel = _feedbackService.GetFeedbackDetails(id.Value);
            return View(feedbackDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Edit(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            _feedbackService.EditFeedback(feedbackDetailsViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            FeedbackDetailsViewModel feedbackDetailsViewModel = _feedbackService.GetFeedbackDetails(id.Value);
            return View(feedbackDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Delete(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            _feedbackService.DeleteFeedback(feedbackDetailsViewModel);
            return RedirectToAction("Index");
        }
    }
}
