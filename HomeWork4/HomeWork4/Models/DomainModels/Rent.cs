using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4.Models.DomainModels
{
    public class Rent
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public User User { get; set; }
        public int Price { get; set; }


    }
}
