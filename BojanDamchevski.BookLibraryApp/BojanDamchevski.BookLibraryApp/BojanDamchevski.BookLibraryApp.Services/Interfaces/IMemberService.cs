using BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels;
using System.Collections.Generic;

namespace BojanDamchevski.BookLibraryApp.Services.Interfaces
{
    public interface IMemberService
    {
        List<MemberListViewModel> GetAllMembers();
        MemberDetailsViewModel GetMemberDetails(int id);
        void CreateNewMember(AddMemberViewModel addMemberViewModel);
        void AddBook(MemberBookReservationViewModel memberBookReservationViewModel);
        AddMemberViewModel GetMemberForEditing(int id);
        void EditMember(AddMemberViewModel addMemberViewModel);
        void DeleteMember(int id);
        List<BookReservationsDDViewModel> GetBookReservationsDD(int memberId);
        void DeteleBookAndReservation(int reservationId, int memberId);
    }
}
