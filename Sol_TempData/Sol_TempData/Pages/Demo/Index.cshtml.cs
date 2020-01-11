using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sol_TempData
{
    public class IndexModel : PageModel
    {

        [TempData]
        public string Data { get; set; }

        [TempData]
        public String DataPeek { get; set; }

        public void OnGet()
        {
            Data = "Hello";

            DataPeek = "Razor";
        }
    }
}