using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels;

namespace BojanDamchevski.BookLibraryApp.Mappers
{
    public static class BookMapper
    {
        public static BookListViewModel ToBookListViewModel(this Book book)
        {
            return new BookListViewModel
            {
                Id = book.Id,
                Title = book.Title
            };
        }
        public static BookDetailsViewModel ToBookDetailsViewModel(this Book book)
        {
            return new BookDetailsViewModel
            {
                Id = book.Id,
                BookTitle = book.Title,
                AuthorFullName = $"{book.Author.FirstName} {book.Author.LastName}",
                BookGenre = book.Genre
            };
        }
        public static Book ToBook(this AddBookViewModel book)
        {
            return new Book
            {
                Genre = book.NewBookGenre,
                Title = book.NewTitle
            };
        }
        public static AddBookViewModel ToAddBookViewModel(this Book book)
        {
            return new AddBookViewModel
            {
                NewId = book.Id,
                AuthorId = book.Author.Id,
                NewBookGenre = book.Genre,
                NewTitle = book.Title
            };
        }
    }
}
