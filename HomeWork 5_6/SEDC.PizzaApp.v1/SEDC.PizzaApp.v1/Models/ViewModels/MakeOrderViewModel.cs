using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class MakeOrderViewModel
    {

        [Display(Name ="First Name : ")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name : ")]
        public string LastName { get; set; }

        [Display(Name = "Phone : ")]
        public long Phone { get; set; }

        [Display(Name = "Addres : ")]
        public string Addres { get; set; }

        [Display(Name ="Select Pizza Size : ")]
        public PizzaSize Size { get; set; }

        [Display(Name =" Name of Pizza : ")]
        public string PizzaName { get; set; }


        public List<string>Pizzas{ get; set; }
    }
}
