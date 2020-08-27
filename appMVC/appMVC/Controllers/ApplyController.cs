using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using appMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace appMVC.Controllers
{
    public class ApplyController : Controller
    {
        public IActionResult apply()
        {

            Car yugo = new Car();
            yugo.Id = 1;
            yugo.Color = "Blue";
            yugo.Name = "Yugo";
            yugo.Model = "Coral55";
            yugo.Year = 1990;
            



            return View(yugo);
        }

        public IActionResult index()
        {
            return View();
        }
    }
}
