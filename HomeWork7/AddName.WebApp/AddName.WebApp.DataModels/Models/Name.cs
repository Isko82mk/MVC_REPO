using System;
using System.Collections.Generic;
using System.Text;

namespace AddName.WebApp.DomainModels.Models
{
   public class Name
    {
        public int Id { get; set; }
        public string MyName { get; set; }
        public Feedback Feedback { get; set; }
    }
}
