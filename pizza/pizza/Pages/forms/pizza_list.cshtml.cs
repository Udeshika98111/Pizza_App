using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizza.models;

namespace pizza.Pages
{
    public class pizza_listModel : PageModel
    {
        [BindProperty]

        public PizzaModel pizzas { get; set; }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/cheakOut/comfrom", new { pizzas.pizzaName }) ;
        }
    }
}
