using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System.Collections.Generic;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackListViewModel> GetAllFeedbacks();
        FeedbackDetailsViewModel GetFeedbackDetails(int id);
        void AddFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel);
        bool CheckFeedbacksLimit(FeedbackDetailsViewModel feedbackDetailsViewModel);
        void EditFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel);
        void DeleteFeedback(FeedbackDetailsViewModel feedbackDetailsViewModel);
    }
}
