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
    public class OrdersController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> ordersDb = StaticDb.Orders;
            List<OrderListViewModel> orderListViewModels = ordersDb
                .Select(x => OrderMapper.OrderToOrderListViewModel(x))
                .ToList();
            ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Title"] = "Order list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            ViewData["FirstUser"] = StaticDb.Users.First();
            return View(orderListViewModels);
        }
        [Route("{controller}/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            List<Order> orders = StaticDb.Orders;
            if (id == null)
            {
                return View("ResourceNotFound");
            }
            ViewBag.Message = "You are on the order details page";
            ViewData["Title"] = "Details list";
            ViewBag.User = StaticDb.Users.First();
            Order orderDb = orders.FirstOrDefault(o => o.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound");
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
        [Route("{controller}/JsonData")]
        public IActionResult JsonReturn()
        {
            return new JsonResult(StaticDb.Pizzas);
        }
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            List<Order> orders = StaticDb.Orders;
            if (id == null)
            {
                return View("ResourceNotFound");
            }
            Order orderDb = orders.FirstOrDefault(o => o.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound");
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);

            return View(orderDetailsViewModel);
        }
    }


}
