using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.WebApp.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackService _feedbackService;
        
        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }


        [HttpGet]
        public IActionResult IndexFeedback()
        {
            return View();
        }
        [HttpPost]
        public IActionResult IndexFeedback(FeedbackViewModel model)
        {
            _feedbackService.CreateComment(model);
            return View();
        }

        [HttpGet]
        public IActionResult GetComments()
        {
             var comments = _feedbackService.GetFeetbacks();

            return View(comments);
        }

    }
}
