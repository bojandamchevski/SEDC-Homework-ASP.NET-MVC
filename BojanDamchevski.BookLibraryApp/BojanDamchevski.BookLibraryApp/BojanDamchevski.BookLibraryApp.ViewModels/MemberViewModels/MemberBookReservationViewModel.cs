using System;
using System.ComponentModel.DataAnnotations;

namespace BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels
{
    public class MemberBookReservationViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Books:")]
        public int BookId { get; set; }
        [Display(Name = "Reservation:")]
        public DateTime ReservationTime { get; set; }
        public int MemberId { get; set; }
        public int ReservationId { get; set; }
    }
}
