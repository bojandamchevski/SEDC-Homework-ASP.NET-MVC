using BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels;
using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.Services.Interfaces
{
    public interface IBookService
    {
        List<BookListViewModel> GetAllBooks();
        BookDetailsViewModel GetBookDetails(int id);
        void CreateBook(AddBookViewModel addBookViewModel);
        AddBookViewModel GetBookForEditing(int id);
        void EditBook(AddBookViewModel addBookViewModel);
        void DeleteBook(int id);
    }
}
