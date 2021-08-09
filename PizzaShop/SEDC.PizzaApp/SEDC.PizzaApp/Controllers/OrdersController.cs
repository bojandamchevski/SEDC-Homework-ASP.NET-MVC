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
            List<Order> orders = StaticDb.Orders;
            if (id == null)
            {
                return new EmptyResult();
;            }
            Order order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return new EmptyResult();
            }
            return View(order);
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
