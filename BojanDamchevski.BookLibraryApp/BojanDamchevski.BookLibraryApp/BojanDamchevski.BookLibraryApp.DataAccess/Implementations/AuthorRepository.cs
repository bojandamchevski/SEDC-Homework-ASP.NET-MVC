using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.DataAccess.Implementations
{
    public class AuthorRepository : IRepository<Author>
    {
        public void DeleteById(int id)
        {
            Author authorDb = StaticDb.AuthorsDb.FirstOrDefault(x => x.Id == id);
            StaticDb.AuthorsDb.Remove(authorDb);
        }

        public List<Author> GetAll()
        {
            return StaticDb.AuthorsDb;
        }

        public Author GetById(int id)
        {
            return StaticDb.AuthorsDb.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Author entity)
        {
            entity.Id = StaticDb.AuthorsDb.Last().Id + 1;
            StaticDb.AuthorsDb.Add(entity);
            return entity.Id;
        }

        public void Update(Author entity)
        {
            Author authorDb = StaticDb.AuthorsDb.FirstOrDefault(x => x.Id == entity.Id);
            int entityndex = StaticDb.AuthorsDb.IndexOf(authorDb);
            StaticDb.AuthorsDb[entityndex] = entity;
        }
    }
}
