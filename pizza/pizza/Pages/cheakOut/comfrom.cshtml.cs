using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizza.models;

namespace pizza.Pages.cheakOut
{
    [BindProperties(SupportsGet = true)]
    public class comfromModel : PageModel
    {
        public string pizzaName { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(pizzaName))
            {
                pizzaName = "Custom pizzas";
            }
        }
    }
}
