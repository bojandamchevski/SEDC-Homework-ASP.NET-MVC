using System.Collections.Generic;

namespace SEDC.BookLibraryApp.Domain.Models
{
    public class Member : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public List<Book> Books { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Member()
        {
            Books = new List<Book>();
            Reservations = new List<Reservation>();
        }
    }
}
