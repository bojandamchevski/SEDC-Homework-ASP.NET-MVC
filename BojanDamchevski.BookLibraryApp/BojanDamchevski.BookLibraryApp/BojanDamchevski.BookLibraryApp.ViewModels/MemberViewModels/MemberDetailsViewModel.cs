using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels
{
    public class MemberDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> BooksAndReservations { get; set; }
        public int DeleteReservationId { get; set; }
    }
}
