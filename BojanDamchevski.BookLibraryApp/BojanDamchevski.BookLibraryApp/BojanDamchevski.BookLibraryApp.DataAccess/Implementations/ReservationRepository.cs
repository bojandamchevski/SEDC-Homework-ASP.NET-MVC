using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.DataAccess.Implementations
{
    public class ReservationRepository : IRepository<Reservation>
    {
        public void DeleteById(int id)
        {
            Reservation Reservation = StaticDb.ReservationsDb.FirstOrDefault(x => x.Id == id);
            StaticDb.ReservationsDb.Remove(Reservation);
        }

        public List<Reservation> GetAll()
        {
            return StaticDb.ReservationsDb;
        }

        public Reservation GetById(int id)
        {
            return StaticDb.ReservationsDb.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Reservation entity)
        {
            entity.Id = StaticDb.ReservationsDb.Last().Id + 1;
            StaticDb.ReservationsDb.Add(entity);
            return entity.Id;
        }

        public void Update(Reservation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
