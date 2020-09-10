using HomeWork4.Models.DomainModels;
using HomeWork4.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HomeWork4
{
    public static class DB
    {
        public static List<Book> Books { get; set; }
        public static List<User>Users { get; set;}
        public static List<Rent> Rents { get; set;}


        static DB()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id =1,
                    Name="The Ultimate Hitchhiker's Guide ",
                    Author ="Douglas Adams",
                    Genre = Genre.Commedy,
                    Price =5
                },

                new Book()
                {
                    Id =2,
                    Name="Harry Potter and the Philosopher's Stone",
                    Author ="J. K. Rowling",
                    Genre = Genre.Childrens,
                    Price =10
                },

                new Book()
                {
                    Id =3,
                    Name="Animal Farm",
                    Author ="George Orwell",
                    Genre = Genre.Fiction,
                    Price =12
                },

                new Book()
                {
                    Id =1,
                    Name="Odyssey",
                    Author ="Homer",
                    Genre = Genre.Poetry,
                    Price =8
                },
            };

            Users = new List<User>()
            {
                new User()
                {
                    Id=1,
                    FirstName = "Don",
                    LastName = "Jonson",
                    Addres = "California Road 125",
                    Phone = 1654165
                },
                new User()
                {
                    Id=2,
                    FirstName = "John",
                    LastName = "Macomb",
                    Addres = "Atlanta Road 125",
                    Phone = 54654113
                },
                new User()
                {
                    Id=3,
                    FirstName = "Mike",
                    LastName = "Thison",
                    Addres = "HollywoodRoad",
                    Phone = 4984465
                }

            };

            Rents = new List<Rent>()
            {
                new Rent()
                {
                    Id=1,
                    Books=new List<Book>(){Books[0]},
                    User = Users[0],
                    Price = Books[0].Price
                },
                new Rent()
                {
                    Id=2,
                    Books=new List<Book>(){Books[0],Books[1]},
                    User = Users[2],

                },
                new Rent()
                {
                    Id=3,
                    Books=new List<Book>(){Books[2]},
                    User = Users[1],

                },

            };

            Rents[0].Price = BookPrice(Rents[0].Books);
            Rents.Add(Rents[0]);

            Rents[1].Price = BookPrice(Rents[1].Books);
            Rents.Add(Rents[1]);

            Rents[2].Price = BookPrice(Rents[2].Books);
            Rents.Add(Rents[2]);


        }

         private static int BookPrice(List<Book> books)
        {
            var total = 0;

            foreach (var item in books)
            {
                total += item.Price;
            }
            return total;
        }

    }
}
