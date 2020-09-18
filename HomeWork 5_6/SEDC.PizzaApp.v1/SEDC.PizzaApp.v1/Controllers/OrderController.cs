using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enum;
using SEDC.PizzaApp.v1.Models.ViewModels;
using System.IO;
using SEDC.PizzaApp.v1.Models.Helpers;
using Microsoft.AspNetCore.Hosting;

namespace SEDC.PizzaApp.v1.Controllers
{
   
    public class OrderController : Controller
    {

        private readonly IHostingEnvironment _webhost;

        public OrderController(IHostingEnvironment webhost)
        {
            _webhost = webhost;
        }


        [HttpGet]
        public IActionResult Index()
        {
            //transfer data form a Model          
            User person = new User()
            {
                FirstName = "Bob",
                LastName = "Bosky",
                Address = "Praska 90b",
                Phone = 12345,
            };

            Pizza pizza = new Pizza()
            {
                Name = "Capri",
                Size = PizzaSize.Family,
                Price = 12.50
            };

            Pizza pizza2 = new Pizza()
            {
                Name = "Quatro",
                Size = PizzaSize.Medium,
                Price = 8.50
            };

            Order order = new Order()
            {
                Id = 12,
                Price = pizza.Price + 2,
                User = person,
                IsDelivered = true,
                Pizzas = new List<Pizza>() { pizza, pizza2 }
            };

            //ViewData
            ViewData.Add("Title", "Welcome to our order page!");
            ViewData.Add("Username", person.FirstName);

            //ViewBag
            ViewBag.Greeting = "We have the best pizza in the world!";
            ViewBag.Pizza = pizza;

            return View(order);
        }


        [HttpGet]
        public IActionResult Order()
        {
            var menu = StaticDb.Menu;

            var pizzaNames = new List<string>();

            foreach (var item in menu)
            {
                pizzaNames.Add(item.Name);
            }

            var uniquePizzaName = pizzaNames.Distinct().ToList();

            var makeOrderViewModel = new MakeOrderViewModel()
            {
                Pizzas = uniquePizzaName
            };


            return View(makeOrderViewModel);
        }
        [HttpPost]
        public IActionResult Order(MakeOrderViewModel model)
        {

            var pizza = StaticDb.Menu.FirstOrDefault(x => x.Name == model.PizzaName);

            var lastUserId = StaticDb.Users.Last().Id;
            var user = new User()
            {
                Id = lastUserId + 1,
                FirstName=model.FirstName,
                LastName=model.LastName,
                Address=model.Addres,
                Phone=model.Phone
            };

            var lastOrderId = StaticDb.Orders.Last().Id;
            var order = new Order()
            {
                Id=lastOrderId,
                User=user,
                Pizzas= new List<Pizza>() { pizza},
                Price=pizza.Price+50,
                IsDelivered=false

            };


            StaticDb.Orders.Add(order);
            StaticDb.Users.Add(user);


            return View("_ThankYou");
        }


        [HttpGet]
        public IActionResult Orders() 
        {
            var dbOrders = StaticDb.Orders;

            var orders = new List<OrderViewModel>();

            foreach (var order in dbOrders)
            {
                var tempOrder = new OrderViewModel()
                {
                    Id = order.Id,
                    FullName = order.User.FirstName + " " + order.User.LastName,
                    Address = order.User.Address,
                    Contact = order.User.Phone,
                    Price = order.Price,
                    IsDelievered = order.IsDelivered,
                    Pizzas = order.Pizzas
                };
                orders.Add(tempOrder);
            }

            var ordersViewModel = new OrdersViewModel()
            {
                FirstPizza = dbOrders[0].Pizzas[0].Name,
                FirstPersonName = $"{dbOrders[0].User.FirstName} {dbOrders[0].User.LastName}",
                NumberOfOrders = dbOrders.Count,
                Orders = orders
            };

            return View(ordersViewModel);
        }

        [HttpGet]
        public IActionResult Details(int? id) 
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null) 
            {
                return RedirectToAction("Index");
            }

            //mapping
            var orderDetails = new OrderViewModel()
            {
                Id = order.Id,
                FullName = order.User.FirstName + " " + order.User.LastName,
                Address = order.User.Address,
                Contact = order.User.Phone,
                Price = order.Price,
                IsDelievered = order.IsDelivered,
                Pizzas = order.Pizzas
            };
            
            return View(orderDetails);
        }

        [HttpGet]
        public IActionResult Menu() 
        {
            var dbMenu = StaticDb.Menu;

            var menu = new MenuViewModel()
            {
                Menu = dbMenu
            };

            return View(menu);
        }


        [HttpGet]
        public IActionResult AddPizza()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPizza(PizzaViewModel model )
        {
            var lastPizzaId = StaticDb.Menu.Last().Id;
            var pizza = new Pizza()
            {
                Id = lastPizzaId + 1,
                Name=model.Name,
                Price=model.Price,
                Size=model.Size
                
            };

            StaticDb.Menu.Add(pizza);

            return RedirectToAction("Menu");
        }




        [HttpGet]
        public IActionResult UploadImg()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult UploadImg(IFormFile imgFile)
        {
            var ic = new ImageClass();
            var imgsFolderPath = Path.Combine(_webhost.WebRootPath,"img/pizza");

             var di = new DirectoryInfo(imgsFolderPath);

            List<FileInfo> fileInfoImgs = di.GetFiles().ToList();

            ic.FileImage = fileInfoImgs;

            var saveImg = Path.Combine(_webhost.WebRootPath, "img/pizza", imgFile.FileName);

            var imgExtens = Path.GetExtension(imgFile.FileName);

            using (var uploadImg = new FileStream(saveImg, FileMode.Create))
            {
                imgFile.CopyTo(uploadImg);
              
            }


            return View(ic);
           
        }




    }
}
