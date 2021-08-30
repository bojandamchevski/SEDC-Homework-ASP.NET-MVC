using BojanDamchevski.BookLibraryApp.Domain.Enums;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.DataAccess
{
    public static class StaticDb
    {
        static StaticDb()
        {
            AuthorsDb = new List<Author>
            {
                new Author
                {
                    Id = 1,
                    FirstName = "Agatha",
                    LastName = "Christie"
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Dan",
                    LastName = "Brown"
                }
            };
            ReservationsDb = new List<Reservation>
            {
               new Reservation
               {
                   Id = 1,
                   Date = DateTime.Now
               },
               new Reservation
               {
                   Id = 2,
                   Date = DateTime.Now.AddDays(2)
               },
               new Reservation
               {
                   Id = 3,
                   Date = DateTime.Now.AddDays(5)
               },
               new Reservation
               {
                   Id = 4,
                   Date = DateTime.Now.AddDays(10)
               }
            };
            BooksDb = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Author = AuthorsDb[0],
                    Genre = BookGenreEnum.Mistery,
                    Title = "Murder on Orient Express"
                },
                new Book
                {
                    Id = 2,
                    Author = AuthorsDb[0],
                    Genre = BookGenreEnum.Mistery,
                    Title = "Death on the Nile"
                },
                new Book
                {
                    Id = 3,
                    Author = AuthorsDb[1],
                    Genre = BookGenreEnum.Mistery,
                    Title = "The Da Vinci Code"
                },
                new Book
                {
                    Id = 4,
                    Author = AuthorsDb[1],
                    Genre = BookGenreEnum.Mistery,
                    Title = "Inferno"
                }
            };
            BookReservationDb = new List<BookReservation>
            {
                new BookReservation
                {
                    Id = 1,
                    BookId = 1,
                    Book = BooksDb[0],
                    Reservation = ReservationsDb[0],
                    ReservationId = 1
                },
                new BookReservation
                {
                    Id = 2,
                    BookId = 2,
                    Book = BooksDb[1],
                    Reservation = ReservationsDb[1],
                    ReservationId = 2
                },
                new BookReservation
                {
                    Id = 3,
                    BookId = 3,
                    Book = BooksDb[2],
                    Reservation = ReservationsDb[2],
                    ReservationId = 3
                },
                new BookReservation
                {
                    Id = 4,
                    BookId = 4,
                    Book = BooksDb[3],
                    Reservation = ReservationsDb[3],
                    ReservationId = 4
                }
            };
            MembersDb = new List<Member>
            {
               new Member
               {
                   Id = 1,
                   FirstName = "Bojan",
                   LastName = "Damchevski",
                   BookReservations = new List<BookReservation>
                   {
                       BookReservationDb[0],
                       BookReservationDb[2]
                   }
               },
               new Member
               {
                   Id = 2,
                   FirstName = "Stefan",
                   LastName = "Trajkov",
                   BookReservations = new List<BookReservation>
                   {
                       BookReservationDb[3]
                   }
               },
               new Member
               {
                   Id = 3,
                   FirstName = "Jovana",
                   LastName = "Miskimovska",
                   BookReservations = new List<BookReservation>
                   {
                       BookReservationDb[1]
                   }
               }
            };
        }
        public static List<Author> AuthorsDb { get; set; }
        public static List<Reservation> ReservationsDb { get; set; }
        public static List<Book> BooksDb { get; set; }
        public static List<BookReservation> BookReservationDb { get; set; }
        public static List<Member> MembersDb { get; set; }
    }
}
