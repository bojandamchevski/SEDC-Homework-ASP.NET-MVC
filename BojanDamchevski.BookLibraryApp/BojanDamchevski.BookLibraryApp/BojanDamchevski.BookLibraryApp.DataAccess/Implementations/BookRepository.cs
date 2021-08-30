using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.DataAccess.Implementations
{
    public class BookRepository : IRepository<Book>
    {
        public BookRepository()
        {

        }
        public void DeleteById(int id)
        {
            Book bookDb = StaticDb.BooksDb.FirstOrDefault(x => x.Id == id);
            StaticDb.BooksDb.Remove(bookDb);
        }

        public List<Book> GetAll()
        {
            return StaticDb.BooksDb;
        }

        public Book GetById(int id)
        {
            return StaticDb.BooksDb.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Book entity)
        {
            entity.Id = StaticDb.BooksDb.Last().Id + 1;
            StaticDb.BooksDb.Add(entity);
            return entity.Id;
        }

        public void Update(Book entity)
        {
            Book bookDb = StaticDb.BooksDb.FirstOrDefault(x => x.Id == entity.Id);
            int entityndex = StaticDb.BooksDb.IndexOf(bookDb);
            StaticDb.BooksDb[entityndex] = entity;
        }
    }
}
