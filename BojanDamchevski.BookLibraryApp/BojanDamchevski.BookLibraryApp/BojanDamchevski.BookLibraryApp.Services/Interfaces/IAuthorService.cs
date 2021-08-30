using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;
using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.Services.Interfaces
{
    public interface IAuthorService
    {
        List<AuthorDDViewModel> GetAuthorsForDD();
        void CreateAuthor(AddAuthorViewModel addAuthorViewModel);
        AuthorDetailsViewModel GetAuthorBooks(int id);
        AddAuthorViewModel GetAuthorForEditing(int id);
        void EditAuthor(AddAuthorViewModel authorDetailsViewModel);
        void DeleteAuthor(int id);
    }
}
