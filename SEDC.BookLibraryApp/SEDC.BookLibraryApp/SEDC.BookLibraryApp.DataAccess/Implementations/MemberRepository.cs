using SEDC.BookLibraryApp.DataAccess.Interfaces;
using SEDC.BookLibraryApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.BookLibraryApp.DataAccess.Implementations
{
    public class MemberRepository : IRepository<Member>
    {
        public void DeleteById(int id)
        {
            Member memberDb = StaticDb.MembersDb.FirstOrDefault(m => m.Id == id);
            if (memberDb != null)
            {
                StaticDb.MembersDb.Remove(memberDb);
            }
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
            Member orderDb = StaticDb.MembersDb.FirstOrDefault(x => x.Id == entity.Id);
            int index = StaticDb.MembersDb.IndexOf(orderDb);
            StaticDb.MembersDb[index] = entity;
        }
    }
}
