using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;
        public FeedbackService(IRepository<Feedback> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public List<FeedbackListViewModel> GetAllFeedbacks()
        {
            List<Feedback> dbFeedback = _feedbackRepository.GetAll();
            return dbFeedback.Select(f => f.FeedbackToFeedbackListViewModel()).ToList();
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"The feedback with id {id} was not found!");
            }
            return feedback.FeedbackToFeedbackDetailsViewModel();
        }
        public void AddFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            Feedback feedback = feedbackDetailsViewModel.ToFeedback();
            _feedbackRepository.Insert(feedback);
        }

        public bool CheckFeedbacksLimit(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();
            List<string> total = new List<string>();
            total = feedbacks.Where(x => x.Email == feedbackDetailsViewModel.Email).Select(x => x.Email).ToList();
            if (total.Count == 0)
            {
                return true;
            }
            else
            {
                int num = total.Count();
                if (num > 2)
                {
                    return false;
                }
            }
            return true;

        }

        public void EditFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {

            _feedbackRepository.Update(feedbackDetailsViewModel.ToFeedback());
        }

        public void DeleteFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel)
        {
            _feedbackRepository.DeleteById(feedbackDetailsViewModel.Id);
        }
    }
}
