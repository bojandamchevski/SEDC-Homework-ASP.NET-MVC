using SEDC.BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace SEDC.BookLibraryApp.DataAccess
{
    public static class StaticDb
    {
        static StaticDb()
        {
            BooksDb = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Murder on the Orient Express"

            },
            new Book
            {
                Id = 2,
                Title = "Death on the Nile"

            },
            new Book
            {
                Id = 3,
                Title = "Da Vinci Code"

            },
            new Book
            {
                Id = 4,
                Title = "Inferno"

            }
        };
            AuthorsDb = new List<Author>
        {
            new Author
            {
                Id = 1,
                FirstName = "Agatha",
                LastName = "Christie",
                AuthorBooks =
                {
                    BooksDb[0],
                    BooksDb[1]
                }
            },
            new Author
            {
                Id = 2,
                FirstName = "Dan",
                LastName = "Brown",
                AuthorBooks =
                {
                    BooksDb[2],
                    BooksDb[3]
                }
            }
        };
            ReservationsDb = new List<Reservation>
        {
            new Reservation
            {
                Id = 1,
                ReservationTime = DateTime.Now.AddMonths(1)
            },
            new Reservation
            {
                Id = 2,
                ReservationTime = DateTime.Now.AddMonths(2)
            },
            new Reservation
            {
                Id = 3,
                ReservationTime = DateTime.Now.AddMonths(3)
            }
        };
            MembersDb = new List<Member>
        {
            new Member
            {
                Id = 1,
                FirstName = "Bojan",
                LastName = "Damchevski",
                Books =
                {
                    BooksDb[0],
                    BooksDb[2],
                },
                IsActive = true,
                Reservations =
                {
                    ReservationsDb[0]
                }
            },
            new Member
            {
                Id = 2,
                FirstName = "Stefan",
                LastName = "Trajkov",
                Books =
                {
                    BooksDb[1],
                    BooksDb[3],
                },
                IsActive = true,
                Reservations =
                {
                    ReservationsDb[1]
                }
            },
            new Member
            {
                Id = 3,
                FirstName = "Jovana",
                LastName = "Miskimovska",
                Books =
                {
                    BooksDb[1],
                    BooksDb[2],
                },
                IsActive = true,
                Reservations =
                {
                    ReservationsDb[2]
                }
            }
        };



        }

        public static List<Member> MembersDb { get; set; }
        public static List<Author> AuthorsDb { get; set; }
        public static List<Book> BooksDb { get; set; }
        public static List<Reservation> ReservationsDb { get; set; }
    }
}
