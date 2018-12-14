using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class CatalogIndexViewModel
    {
        //2 dropdown // catalogItems
        public IEnumerable<Event> CatalogEvents { get; set; }
        public IEnumerable<SelectListItem> Brands { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }       
        public int? CatagoriesFilterApplied { get; set; }
        public int? SubCatagoriesFilterApplied { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
   
    }
}
