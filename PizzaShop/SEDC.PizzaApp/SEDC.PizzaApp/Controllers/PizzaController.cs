using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            return View(pizza);
        }
        [Route("SeePizzas")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
