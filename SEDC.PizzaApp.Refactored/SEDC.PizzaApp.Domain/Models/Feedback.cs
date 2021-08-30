namespace SEDC.PizzaApp.Domain.Models
{
    public class Feedback : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public Feedback()
        {

        }
    }
}
