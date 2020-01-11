using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sol_TempData
{
    public class View2Model : PageModel
    {
        public String Message { get; set; }

        public String MessagePeek { get; set; }

        public void OnGet()
        {
            Message = TempData["Data"] as string;
            TempData.Keep();

            MessagePeek = TempData.Peek("DataPeek") as string;
        }
    }
}