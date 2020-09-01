using Microsoft.AspNetCore.Mvc;

namespace HomeWork2.Controllers
{
    [Route("Index/[action]")]
    public class AboutController : Controller
    {
        public IActionResult AboutPage()
        {
            return View();
        }

        [Route("bridges")]
        public ActionResult SecondPage()
        {
            return View();
        }


        public ActionResult Bridges()
        {
            return View("secondPage");
        }


        public ActionResult JsonGGBridge()
        {
            var bridge = new
            {
                Name = "Golden Gate Bridge,",
                Width = "2,737 m",
                Height = " 227 m ",
                City = "San Francisco",
            };

            return new JsonResult(bridge);
        }




    }
}
