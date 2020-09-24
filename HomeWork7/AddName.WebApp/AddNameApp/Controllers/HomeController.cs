using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddName.WebApp.DomainModels.Models;
using AddName.WebApp.Services.Interfaces;
using AddName.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AddNameApp.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }



        [HttpGet]
        public IActionResult AddName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddName(NameViewModel model)
        {
            _homeService.CreateNewName(model);
            return View();
        }


        [HttpGet]
        public IActionResult GetNames()
        {
            var names = _homeService.GetAllNames();

            return View(names);
        }




        [HttpGet]
        public IActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Feedback(FeedbackViewModel model)
        {
            _homeService.CreateNewComment(model);
         
            return View();
        }



        [HttpGet]
        public IActionResult GetAllFeedbacks()
        {
          var reactions=_homeService.GetFeedbacks();

            return View(reactions);
        }





    }
}
