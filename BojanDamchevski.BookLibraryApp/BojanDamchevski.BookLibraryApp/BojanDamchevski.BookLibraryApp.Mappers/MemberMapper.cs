using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.Mappers
{
    public static class MemberMapper
    {
        public static MemberListViewModel ToMemberListViewModel(this Member member)
        {
            return new MemberListViewModel
            {
                Id = member.Id,
                MemberFullName = $"{member.FirstName} {member.LastName}",
                NumberOfBooks = member.BookReservations.Count()
            };
        }
        public static MemberDetailsViewModel ToMemberDetailsViewModel(this Member member)
        {
            return new MemberDetailsViewModel
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName,
                BooksAndReservations = member.BookReservations.Select(x => $"{x.Book.Title} [{x.Book.Genre}] - {x.Book.Author.FirstName} {x.Book.Author.LastName} | Reservation: {x.Reservation.Date.ToString("dd/M/yyyy")}").ToList()
            };
        }
        public static Member ToMember(this AddMemberViewModel addMemberViewModel)
        {
            return new Member
            {
                FirstName = addMemberViewModel.NewFirstName,
                LastName = addMemberViewModel.NewLastName,
                BookReservations = new List<BookReservation>()
            };
        }
        public static AddMemberViewModel ToAddMemberViewModel(this Member Member)
        {
            return new AddMemberViewModel
            {
                NewId = Member.Id,
                NewFirstName = Member.FirstName,
                NewLastName = Member.LastName
            };
        }
        public static BookReservation ToBookReservation(this MemberBookReservationViewModel memberBookReservationViewModel)
        {
            return new BookReservation
            {
                BookId = memberBookReservationViewModel.BookId
            };
        }
        public static BookReservationsDDViewModel ToBookReservationsDDViewModel(this BookReservation bookReservation)
        {
            return new BookReservationsDDViewModel
            {
                Id = bookReservation.Id,
                Reservation = $"{bookReservation.Book.Title} {bookReservation.Reservation.Date}"
            };
        }
    }
}
