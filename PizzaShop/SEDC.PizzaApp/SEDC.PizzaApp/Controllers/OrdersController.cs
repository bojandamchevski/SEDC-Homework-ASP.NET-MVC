using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("OrdersController/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == 0)
            {
                return new EmptyResult();
            }
            List<Order> orders = StaticDb.Orders;
            return View(orders);
        }
        [Route("OrdersController/JsonData")]
        public IActionResult JsonReturn()
        {
            return new JsonResult(StaticDb.Pizzas);
        }
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }


}
