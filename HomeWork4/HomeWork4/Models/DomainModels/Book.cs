using HomeWork4.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4.Models.DomainModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
      
        public int Price { get; set; }
    }
}
