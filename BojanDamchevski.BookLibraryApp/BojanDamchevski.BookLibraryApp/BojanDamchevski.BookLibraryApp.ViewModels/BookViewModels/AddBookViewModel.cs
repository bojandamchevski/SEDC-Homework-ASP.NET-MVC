using BojanDamchevski.BookLibraryApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels
{
    public class AddBookViewModel
    {
        public int NewId { get; set; }
        [Display(Name = "Book title")]
        public string NewTitle { get; set; }
        [Display(Name = "Book genre")]
        public BookGenreEnum NewBookGenre { get; set; }
        [Display(Name = "Authors:")]
        public int AuthorId { get; set; }
    }
}
