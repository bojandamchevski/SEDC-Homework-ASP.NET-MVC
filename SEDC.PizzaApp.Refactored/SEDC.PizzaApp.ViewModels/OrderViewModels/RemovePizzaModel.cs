using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.OrderViewModels
{
    public class RemovePizzaModel
    {
        public int OrderId { get; set; }
        [Display(Name = "Pizzas:")]
        public int PizzaId { get; set; }
    }
}
