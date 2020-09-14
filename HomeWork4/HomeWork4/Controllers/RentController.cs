using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork4.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Rents()
        {
            var dbRents = DB.Rents;

            var rents = new List<RentViewModel>();

            foreach (var item in dbRents)
            {
                var tempRents = new RentViewModel()
                {
                    Id=item.Id,
                    FullName=item.User.FirstName+""+item.User.LastName,
                    Addres =item.User.Addres,
                    Phone=item.User.Phone,
                    Books=item.Books,
                    User=item.User,
                    Price=item.Price,
                    isRented = item.isRented
                };

                rents.Add(tempRents);
            }


            var rentsViewModel = new RentsViewModel()
            {
                Rents = rents
            };
            return View(rentsViewModel);
        }




        public IActionResult Details(int? id)
        {
            var rent = DB.Rents.FirstOrDefault(x=>x.Id==id);

            if (rent ==null)
            {
                return RedirectToAction("index");
            }

            var rentDetails = new RentViewModel()
            {
                Id=rent.Id,
                FullName = rent.User.FirstName+" "+rent.User.LastName,
                Addres = rent.User.Addres,
                Phone= rent.User.Phone,
                User=rent.User,
                Price=rent.Price,
                Books=rent.Books,
                isRented = rent.isRented

                
            };
            return View(rentDetails);
        }

        public IActionResult Titles()
        {
            var dbBooks = DB.Titles;

            var books = new TitlesViewModels()
            {
                Books = dbBooks
            };


            return View(books);
        }


    }
}
