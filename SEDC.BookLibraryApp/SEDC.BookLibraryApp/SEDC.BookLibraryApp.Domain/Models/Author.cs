using System.Collections.Generic;

namespace SEDC.BookLibraryApp.Domain.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> AuthorBooks { get; set; }
        public Author()
        {
            AuthorBooks = new List<Book>();
        }
    }
}
