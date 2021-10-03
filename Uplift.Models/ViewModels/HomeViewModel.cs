using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Uplift.Models.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Category> CategoryList {get; set;}

        public IEnumerable<Service> ServiceList {get; set;}
        
    }
}