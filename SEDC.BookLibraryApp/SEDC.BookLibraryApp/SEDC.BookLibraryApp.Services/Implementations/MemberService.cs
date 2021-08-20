using SEDC.BookLibraryApp.DataAccess.Implementations;
using SEDC.BookLibraryApp.DataAccess.Interfaces;
using SEDC.BookLibraryApp.Domain.Models;
using SEDC.BookLibraryApp.Mappers.Mappers;
using SEDC.BookLibraryApp.Services.Interfaces;
using SEDC.BookLibraryApp.ViewModels.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.BookLibraryApp.Services.Implementations
{
    public class MemberService : IMemberService
    {
        private IRepository<Member> _memberRepository;
        public MemberService()
        {
            _memberRepository = new MemberRepository();
        }
        public List<MemberViewModel> GetAllMembers()
        {
            List<Member> dbMembers = _memberRepository.GetAll();
            return dbMembers.Select(m => MemberMapper.MemberToMemberViewModel(m)).ToList();
        }
    }
}
