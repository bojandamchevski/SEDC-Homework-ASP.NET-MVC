using System.ComponentModel.DataAnnotations;

namespace BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels
{
    public class AddMemberViewModel
    {
        public int NewId { get; set; }
        [Display(Name = "Member first name")]
        public string NewFirstName { get; set; }
        [Display(Name = "Member last name")]
        public string NewLastName { get; set; }
    }
}
