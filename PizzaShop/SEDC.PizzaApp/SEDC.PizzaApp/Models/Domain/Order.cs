﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
