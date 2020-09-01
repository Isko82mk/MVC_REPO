using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork2.Controllers
{
     
    public class HomeController : Controller
    {   
         
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Redirect(int? id)
        {
            if (id.HasValue)
            {
                return View("order");
            }
            return View("index");
        }

        public IActionResult Redirect1(int?id)
        {
            if (id.HasValue)
            {
                return View("order");
            }
            return new RedirectResult("index");
        }



        public IActionResult Order()
        {
            return View();
        }

   





    }
}
