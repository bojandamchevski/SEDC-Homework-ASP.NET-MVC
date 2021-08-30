using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;

namespace BojanDamchevski.BookLibraryApp.Mappers
{
    public static class AuthorMapper
    {
        public static AuthorDDViewModel ToAuthorDDViewModel(this Author author)
        {
            return new AuthorDDViewModel
            {
                Id = author.Id,
                AuthorFullName = $"{author.FirstName} {author.LastName}"
            };
        }
        public static AuthorDetailsViewModel ToAuthorDetailsViewModel(this Author author)
        {
            return new AuthorDetailsViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName
            };
        }
        public static AddAuthorViewModel ToAddAuthorViewModel(this Author author)
        {
            return new AddAuthorViewModel
            {
                NewId = author.Id,
                NewFirstName = author.FirstName,
                NewLastName = author.LastName
            };
        }
    }
}
