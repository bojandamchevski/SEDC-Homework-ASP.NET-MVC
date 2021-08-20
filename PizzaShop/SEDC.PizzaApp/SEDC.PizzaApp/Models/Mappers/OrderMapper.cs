using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.IsOnPromotion ? order.Pizza.Price - 50 : order.Pizza.Price,
                UserAddress = order.User.Address,
                Delivered = order.Delivered
            };
        }

        public static OrderListViewModel OrderToOrderListViewModel(Order order)
        {
            return new OrderListViewModel
            {
                Id = order.Id,
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }
        public static Order ToOrder(OrderViewModel orderViewModel)
        {
            User userDb = StaticDb.Users.FirstOrDefault(u => u.Id == orderViewModel.UserId);
            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(u => u.Name == orderViewModel.PizzaName);
            return new Order
            {
                Delivered = orderViewModel.IsDelivered,
                PaymentMethod = orderViewModel.PaymentMethod,
                Id = orderViewModel.Id,
                User = userDb,
                Pizza = pizzaDb
            };
        }
    }
}
