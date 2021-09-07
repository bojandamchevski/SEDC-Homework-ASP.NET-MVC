﻿using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.DataAccess.EFImplementations
{
    public class OrderEFRepository : IRepository<Order>
    {
        private PizzaAppDbContext _pizzaAppDbContext;
        public OrderEFRepository(PizzaAppDbContext pizzaAppDbContext)
        {
            _pizzaAppDbContext = pizzaAppDbContext;
        }
        public void DeleteById(int id)
        {
            Order orderDb = _pizzaAppDbContext.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                throw new Exception($"The order with id {id} was not found!");
            }
            _pizzaAppDbContext.Orders.Remove(orderDb);
            _pizzaAppDbContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _pizzaAppDbContext.Orders
                .Include(x => x.PizzaOrders)
                .ThenInclude(x => x.Pizza)
                .Include(x => x.User)
                .ToList();
        }

        public Order GetById(int id)
        {
            return _pizzaAppDbContext.Orders
                .Include(x => x.PizzaOrders)
                .ThenInclude(x => x.Pizza)
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            _pizzaAppDbContext.Orders.Add(entity);
            return _pizzaAppDbContext.SaveChanges();
        }

        public void Update(Order entity)
        {
            _pizzaAppDbContext.Orders.Update(entity);
            _pizzaAppDbContext.SaveChanges();
        }
    }
}
