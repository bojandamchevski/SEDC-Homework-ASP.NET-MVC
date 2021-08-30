using BojanDamchevski.BookLibraryApp.Domain.Enums;

namespace BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public BookGenreEnum BookGenre { get; set; }
        public string AuthorFullName { get; set; }
    }
}
