using SEDC.PizzaApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza name:")]
        public string PizzaName { get; set; }
        [Display(Name = "Pizza size:")]
        public PizzaSizeEnum PizzaSize { get; set; }
        [Display(Name = "Pizza promotion:")]
        public bool IsOnPromotion { get; set; }
    }
}
