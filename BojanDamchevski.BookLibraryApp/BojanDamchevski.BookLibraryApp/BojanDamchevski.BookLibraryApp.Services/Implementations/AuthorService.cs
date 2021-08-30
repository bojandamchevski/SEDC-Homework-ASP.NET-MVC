using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.Mappers;
using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private IRepository<Author> _authorRepository;
        private IRepository<Book> _bookRepository;
        public AuthorService(IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
        }

        public void CreateAuthor(AddAuthorViewModel addAuthorViewModel)
        {
            Author newAuthor = new Author
            {
                FirstName = addAuthorViewModel.NewFirstName,
                LastName = addAuthorViewModel.NewLastName
            };
            _authorRepository.Insert(newAuthor);
        }

        public AddAuthorViewModel GetAuthorForEditing(int id)
        {
            Author author = _authorRepository.GetById(id);
            return author.ToAddAuthorViewModel();
        }

        public AuthorDetailsViewModel GetAuthorBooks(int id)
        {
            Author author = _authorRepository.GetById(id);
            List<Book> books = _bookRepository.GetAll();
            List<string> authorBooks = books.Where(x => x.Author.Id == id).Select(x => $"{x.Title} | {x.Genre}").ToList();
            AuthorDetailsViewModel authorDetailsViewModel = author.ToAuthorDetailsViewModel();
            authorDetailsViewModel.Books = authorBooks;
            return authorDetailsViewModel;
        }

        public List<AuthorDDViewModel> GetAuthorsForDD()
        {
            List<Author> authors = _authorRepository.GetAll();
            return authors.Select(x => x.ToAuthorDDViewModel()).ToList();
        }

        public void EditAuthor(AddAuthorViewModel authorDetailsViewModel)
        {
            Author author = _authorRepository.GetById(authorDetailsViewModel.NewId);
            author.FirstName = authorDetailsViewModel.NewFirstName;
            author.LastName = authorDetailsViewModel.NewLastName;
            _authorRepository.Update(author);
        }

        public void DeleteAuthor(int id)
        {
            Author author = _authorRepository.GetById(id);
            _authorRepository.DeleteById(id);
        }
    }
}
