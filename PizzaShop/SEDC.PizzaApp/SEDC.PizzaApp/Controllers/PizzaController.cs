using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
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
            //List<PizzaViewModel> pizzaViewModel = pizzas.Select(p => PizzaMapper.PizzaToPizzaViewModel(p)).ToList();
            List<PizzaViewModel> pizzaViewModel = pizzas.Select(p => p.PizzaToPizzaViewModelWithExtensionMethod(p)).ToList();
            ViewData["Title"] = "Pizzas";
            ViewData["Date"] = DateTime.Now.ToShortDateString();
            ViewBag.Pizzas = pizzaViewModel;
            return View(pizzaViewModel);
        }
        public IActionResult Details(int id)
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = pizzas.FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            PizzaViewModel pizzaViewModel = PizzaMapper.PizzaToPizzaViewModel(pizza);
            ViewBag.PizzaViewModel = pizzaViewModel;
            ViewData["Title"] = "Details";
            ViewData["Date"] = DateTime.Now.ToShortDateString();
            ViewBag.OnePizza = pizzaViewModel;
            return View(pizzaViewModel);
        }
        [Route("SeePizzas")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
