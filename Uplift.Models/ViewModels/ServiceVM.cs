using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Uplift.Models.ViewModels
{
    public class ServiceVM
    {

        public Service Service {get; set;}

        public IEnumerable<SelectListItem> CategoryList {get; set;}

        public IEnumerable<SelectListItem> FrequencyList {get; set;}
        
    }
}