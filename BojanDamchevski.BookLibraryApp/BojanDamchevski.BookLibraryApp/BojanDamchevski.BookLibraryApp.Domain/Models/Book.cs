using BojanDamchevski.BookLibraryApp.Domain.Enums;

namespace BojanDamchevski.BookLibraryApp.Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public BookGenreEnum Genre { get; set; }

    }
}
