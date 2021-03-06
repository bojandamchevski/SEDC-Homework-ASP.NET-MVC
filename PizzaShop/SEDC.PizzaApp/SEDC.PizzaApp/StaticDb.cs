using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Capri",
                Price = 350,
                IsOnPromotion = true,
                PizzaSize = Models.Enums.PizzaSize.Normal,
                HasExtras = true
            },
            new Pizza
            {
                Id = 2,
                Name = "Margarita",
                Price = 380,
                IsOnPromotion = false,
                PizzaSize = Models.Enums.PizzaSize.Family,
                HasExtras = true
            }
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                FirstName = "Bojan",
                LastName = "Damcevski",
                Address = "address1"
            },
            new User
            {
                FirstName = "Stefan",
                LastName = "Trajkov",
                Address = "address2"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                Pizza = Pizzas.First(),
                User = Users.First(),
                PaymentMethod = Models.Enums.PaymentMethod.Card,
                Delivered = true
            },
            new Order
            {
                Id = 2,
                Pizza = Pizzas.Last(),
                User = Users.Last(),
                PaymentMethod = Models.Enums.PaymentMethod.Cash,
                Delivered = false
            }
        };
    }
}
