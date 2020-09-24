using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IFeedbackService
    {
        void CreateComment(FeedbackViewModel model);
        FeedbackViewModel GetFeetbacks();
    }
}
