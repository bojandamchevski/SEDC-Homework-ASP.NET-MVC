using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.DataAccess.Implementations
{
    public class MemberRepository : IRepository<Member>
    {
        public MemberRepository()
        {

        }
        public void DeleteById(int id)
        {
            Member memberDb = StaticDb.MembersDb.FirstOrDefault(x => x.Id == id);
            StaticDb.MembersDb.Remove(memberDb);
        }

        public List<Member> GetAll()
        {
            return StaticDb.MembersDb;
        }

        public Member GetById(int id)
        {
            return StaticDb.MembersDb.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Member entity)
        {
            entity.Id = StaticDb.MembersDb.Last().Id + 1;
            StaticDb.MembersDb.Add(entity);
            return entity.Id;
        }

        public void Update(Member entity)
        {
            Member memberDb = StaticDb.MembersDb.FirstOrDefault(x => x.Id == entity.Id);
            int entityndex = StaticDb.MembersDb.IndexOf(memberDb);
            StaticDb.MembersDb[entityndex] = entity;
        }
    }
}
