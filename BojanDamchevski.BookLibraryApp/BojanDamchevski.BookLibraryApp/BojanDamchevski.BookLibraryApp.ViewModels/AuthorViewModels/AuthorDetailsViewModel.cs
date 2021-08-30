using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels
{
    public class AuthorDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Books { get; set; }
    }
}
