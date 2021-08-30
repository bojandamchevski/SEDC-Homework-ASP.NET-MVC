using System.ComponentModel.DataAnnotations;

namespace BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels
{
    public class AddAuthorViewModel
    {
        public int NewId { get; set; }
        [Display(Name = "Author first name")]
        public string NewFirstName { get; set; }
        [Display(Name = "Author last name")]
        public string NewLastName { get; set; }
    }
}
