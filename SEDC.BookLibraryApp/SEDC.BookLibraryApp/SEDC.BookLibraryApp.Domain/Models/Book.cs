namespace SEDC.BookLibraryApp.Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Book()
        {

        }
    }
}
