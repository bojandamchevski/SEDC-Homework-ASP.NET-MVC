using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class FeedbackMapper
    {
        public static FeedbackListViewModel FeedbackToFeedbackListViewModel(this Feedback feedback)
        {
            return new FeedbackListViewModel
            {
                Id = feedback.Id,
                Name = feedback.Name
            };
        }
        public static FeedbackDetailsViewModel FeedbackToFeedbackDetailsViewModel(this Feedback feedback)
        {
            return new FeedbackDetailsViewModel
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email,
                Message = feedback.Message
            };
        }
        public static Feedback ToFeedback(this FeedbackDetailsViewModel feedback)
        {
            return new Feedback
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email,
                Message = feedback.Message
            };
        }
    }
}
