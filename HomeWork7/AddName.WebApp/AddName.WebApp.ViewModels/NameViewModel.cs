using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddName.WebApp.ViewModels
{
    public class NameViewModel
    {
      
        public string MyName { get; set; }

        public List<string>Names { get; set; }
       

    }
}
