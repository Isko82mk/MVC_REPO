using AddName.WebApp.DomainModels.Models;
using System.Collections.Generic;

namespace AddName.WebApp.DataAccess
{
    public static class StaticDB
    {
        public static List<Name> Names { get; set; }
        public static List<Feedback> Feedbacks { get; set; }


        static StaticDB()
        {
            Names = new List<Name>()
            {
                new Name()
                {
                    Id=1,
                     MyName=""
                }
            };

            Feedbacks = new List<Feedback>()
            {
                new Feedback()
                {
                    Id=1,
                   Coment = ""
                }
            };

        }


    }
}
