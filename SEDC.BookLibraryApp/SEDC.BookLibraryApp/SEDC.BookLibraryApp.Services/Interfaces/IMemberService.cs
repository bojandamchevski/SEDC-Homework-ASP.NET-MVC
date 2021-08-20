using SEDC.BookLibraryApp.ViewModels.ViewModels;
using System.Collections.Generic;

namespace SEDC.BookLibraryApp.Services.Interfaces
{
    public interface IMemberService
    {
        List<MemberViewModel> GetAllMembers();
    }
}
