using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaListViewModel PizzaToPizzaListViewModel(Pizza pizza)
        {
            return new PizzaListViewModel
            {
                Id = pizza.Id,
                PizzaName = pizza.Name
            };
        }
        public static PizzaDetailsViewModel PizzaToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                PizzaName = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
        public static PizzaViewModel PizzaToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                PizzaName = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
        public static Pizza ToPizza(this PizzaViewModel pizzaViewModel)
        {
            return new Pizza
            {
                Id = pizzaViewModel.Id,
                Name = pizzaViewModel.PizzaName,
                PizzaSize = pizzaViewModel.PizzaSize,
                IsOnPromotion = pizzaViewModel.IsOnPromotion
            };
        }
    }
}
