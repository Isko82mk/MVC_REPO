using AddName.WebApp.DataAccess;
using AddName.WebApp.DataAccess.Repositories;
using AddName.WebApp.DomainModels.Models;
using AddName.WebApp.Services.Interfaces;
using AddName.WebApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AddName.WebApp.Services.Services
{
    public class HomeService : IHomeService
    {
        private IRepositories<Name> _nameRepository;
        private IRepositories<Feedback> _feedbackRepository;

        public HomeService(IRepositories<Name> nameRepository,
                           IRepositories<Feedback> feedbackRepository)
        {
            _nameRepository = nameRepository;
            _feedbackRepository = feedbackRepository;
        }


        

        public void CreateNewComment(FeedbackViewModel model)
        {
            var commentId = StaticDB.Feedbacks.Last().Id;

            var dbcommment = new Feedback()
            {
               Id=commentId+1,
               Coment=model.Comment
            };

            _feedbackRepository.Insert(dbcommment);
        }


        public FeedbackViewModel GetFeedbacks()
        {
            var comments = _feedbackRepository.GetAll();

            var feedbackView = new FeedbackViewModel()
            {
                
                Comments = new List<string>()

            };
            foreach (var item in comments)
            {
                feedbackView.Comments.Add(item.Coment);
            }

            return feedbackView;

        }






        public void CreateNewName(NameViewModel model)
        {
            var modelId = StaticDB.Names.Last().Id;

            var dbName = new Name()
            {
                Id = modelId + 1,
                MyName=model.MyName
            };

            _nameRepository.Insert(dbName);
        }

        public NameViewModel GetAllNames()
        {
            var names = _nameRepository.GetAll();

            var nameViewModel = new NameViewModel()
            {
                Names = new List<string>()
            };


            foreach (var item in names)
            {
                nameViewModel.Names.Add(item.MyName);
            }

            return nameViewModel;

        }

      
    }
}
