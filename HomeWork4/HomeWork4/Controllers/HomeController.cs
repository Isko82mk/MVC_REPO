using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Rent(int? id)
        //{
        //    var dbrent = DB.Rents.FirstOrDefault(x=>x.Id==id);

        //    var rentViewModel = new RentViewModel()
        //    {
        //        Id=dbrent.Id,
        //        FullName=dbrent.User.FirstName+" "+dbrent.User.LastName,
        //        Books=dbrent.Books,
        //        Price=dbrent.Price,
        //        Addres=dbrent.User.Addres,
        //        Contact=dbrent.User.Phone
        //    };

        //    return View(rentViewModel);
        //}



        public IActionResult Rents()
        {
            var dbrents = DB.Rents;

            var rents = new List<RentViewModel>();

            foreach (var item in dbrents)
            {
                var tempRents = new RentViewModel()
                {
                    Id=item.Id,
                    FullName=item.User.FirstName+""+item.User.LastName,
                    Books=item.Books,
                    Addres=item.User.Addres,
                    Contact=item.User.Phone,
                    Price=item.Price
                };
                rents.Add(tempRents);
            }

            var rentsViewModel = new RentsViewModel()
            {
                Rents = rents
            };

            return View(rentsViewModel);
        }




    }
}
