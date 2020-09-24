using AddName.WebApp.DomainModels.Models;
using AddName.WebApp.ViewModels;
using System.Collections.Generic;

namespace AddName.WebApp.Services.Interfaces
{
    public interface IHomeService
    {
        void CreateNewName(NameViewModel model);
        NameViewModel GetAllNames();
        void CreateNewComment(FeedbackViewModel model);
        FeedbackViewModel GetFeedbacks();

    }
}
