using SEDC.BookLibraryApp.Domain.Models;
using SEDC.BookLibraryApp.ViewModels.ViewModels;
using System;
using System.Collections.Generic;

namespace SEDC.BookLibraryApp.Mappers.Mappers
{
    public static class MemberMapper
    {
        public static MemberViewModel MemberToMemberViewModel(Member member)
        {
            List<Book> books = member.Books;
            List<Reservation> res = member.Reservations;
            Dictionary<string, string> booksAndAuthors = new Dictionary<string, string>();
            List<DateTime> reservations = new List<DateTime>();
            foreach (Book book in books)
            {
                booksAndAuthors.Add(book.Title, "Author");
            };
            foreach (Reservation date in res)
            {
                reservations.Add(date.ReservationTime);
            };
            return new MemberViewModel
            {
                MemberFullName = $"{member.FirstName} {member.LastName}",
                BooksAndAuthors = booksAndAuthors,
                Reservations = reservations
            };
        }
    }
}
