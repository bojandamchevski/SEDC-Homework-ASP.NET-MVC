using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.DataAccess.Implementations
{
    public class BookReservationRepository : IRepository<BookReservation>
    {
        public void DeleteById(int id)
        {
            BookReservation bookReservation = StaticDb.BookReservationDb.FirstOrDefault(x => x.Id == id);
            StaticDb.BookReservationDb.Remove(bookReservation);
        }

        public List<BookReservation> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public BookReservation GetById(int id)
        {
            return StaticDb.BookReservationDb.FirstOrDefault(x=>x.Id == id);
        }

        public int Insert(BookReservation entity)
        {
            entity.Id = StaticDb.BookReservationDb.Last().Id + 1;
            StaticDb.BookReservationDb.Add(entity);
            return entity.Id;
        }

        public void Update(BookReservation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
