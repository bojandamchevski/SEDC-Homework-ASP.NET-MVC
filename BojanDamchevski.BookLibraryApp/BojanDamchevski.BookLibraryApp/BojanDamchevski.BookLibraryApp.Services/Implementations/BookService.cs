using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.Mappers;
using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.Services.Implementations
{
    public class BookService : IBookService
    {
        private IRepository<Book> _bookRepository;
        private IRepository<Author> _authorRepository;
        public BookService(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public void CreateBook(AddBookViewModel addBookViewModel)
        {
            Author author = _authorRepository.GetById(addBookViewModel.AuthorId);
            Book newBook = new Book
            {
                Genre = addBookViewModel.NewBookGenre,
                Author = author,
                Title = addBookViewModel.NewTitle
            };
            _bookRepository.Insert(newBook);
        }

        public void DeleteBook(int id)
        {
            Book book = _bookRepository.GetById(id);
            _bookRepository.DeleteById(id);
        }

        public void EditBook(AddBookViewModel addBookViewModel)
        {
            Book book = _bookRepository.GetById(addBookViewModel.NewId);
            book.Title = addBookViewModel.NewTitle;
            book.Author = _authorRepository.GetById(addBookViewModel.AuthorId);
            book.Genre = addBookViewModel.NewBookGenre;
            _bookRepository.Update(book);
        }

        public List<BookListViewModel> GetAllBooks()
        {
            List<Book> booksDb = _bookRepository.GetAll();
            return booksDb.Select(b => b.ToBookListViewModel()).ToList();
        }

        public BookDetailsViewModel GetBookDetails(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            return bookDb.ToBookDetailsViewModel();
        }

        public AddBookViewModel GetBookForEditing(int id)
        {
            Book book = _bookRepository.GetById(id);
            return book.ToAddBookViewModel();
        }
    }
}
