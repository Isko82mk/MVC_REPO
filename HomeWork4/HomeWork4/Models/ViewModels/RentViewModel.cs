using HomeWork4.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4.Models.ViewModels
{
    public class RentViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Addres { get; set; }
        public long Phone { get; set; }
        public User User { get; set; }
        public List<Book>Books { get; set; }
        public int Price { get; set; }
        public bool isRented { get; set; }

    }
}
