using SEDC.PizzaApp.v1.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class PizzaViewModel
    {   
        [Display(Name="Enter Pizza Name : ")]
        public string Name { get; set; }

        [Display(Name ="Enter Pizza Price : ")]
        public double Price { get; set; }

        [Display(Name ="Enter Pizza Size : ")]
        public PizzaSize Size { get; set; }
    }
}
