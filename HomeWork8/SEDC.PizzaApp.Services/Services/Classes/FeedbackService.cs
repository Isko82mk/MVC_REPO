using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Services.Services.Classes
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;

        public FeedbackService(IRepository<Feedback> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }



        
        public void CreateComment(FeedbackViewModel model)
        {
            var lastComentId = StaticDb.Feedbacks.Last().Id;

            var dbComment = new Feedback()
            {
                Id= lastComentId+1,
                Comment =model.Comment
            };

            _feedbackRepository.Insert(dbComment);

        }

        public FeedbackViewModel GetFeetbacks()
        {
            var comments = _feedbackRepository.GetAll();

            var feedbackView = new FeedbackViewModel()
            {
                Commentns = new List<string>()
            };

            foreach (var item in comments)
            {
                feedbackView.Commentns.Add(item.Comment);
            }

            return feedbackView;
        }



    }
}
