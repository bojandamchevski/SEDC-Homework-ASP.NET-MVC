using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.Domain.Models
{
    public class Member : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookReservation> BookReservations { get; set; }
    }
}
