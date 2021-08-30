using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.Mappers;
using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BojanDamchevski.BookLibraryApp.Services.Implementations
{
    public class MemberService : IMemberService
    {
        private IRepository<Member> _memberRepository;
        private IRepository<Book> _bookRepository;
        private IRepository<Reservation> _reservationRepository;
        private IRepository<BookReservation> _bookReservationRepository;
        public MemberService(IRepository<Member> memberRepository, IRepository<Book> bookRepository, IRepository<Reservation> reservationRepository, IRepository<BookReservation> bookReservationRepository)
        {
            _memberRepository = memberRepository;
            _bookRepository = bookRepository;
            _reservationRepository = reservationRepository;
            _bookReservationRepository = bookReservationRepository;
        }

        public void AddBook(MemberBookReservationViewModel memberBookReservationViewModel)
        {
            Book newBook = _bookRepository.GetById(memberBookReservationViewModel.BookId);
            Reservation newReservation = new Reservation
            {
                Date = memberBookReservationViewModel.ReservationTime
            };
            _reservationRepository.Insert(newReservation);
            BookReservation newBookReservation = memberBookReservationViewModel.ToBookReservation();
            newBookReservation.Reservation = newReservation;
            newBookReservation.Book = newBook;
            _bookReservationRepository.Insert(newBookReservation);
            Member existingMember = _memberRepository.GetById(memberBookReservationViewModel.MemberId);
            existingMember.BookReservations.Add(newBookReservation);
            _memberRepository.Update(existingMember);
        }

        public void CreateNewMember(AddMemberViewModel addMemberViewModel)
        {
            Member newMember = addMemberViewModel.ToMember();
            _memberRepository.Insert(newMember);
        }

        public void DeleteMember(int id)
        {
            Member member = _memberRepository.GetById(id);
            _memberRepository.DeleteById(id);
        }

        public void EditMember(AddMemberViewModel addMemberViewModel)
        {
            Member member = _memberRepository.GetById(addMemberViewModel.NewId);
            member.FirstName = addMemberViewModel.NewFirstName;
            member.LastName = addMemberViewModel.NewLastName;
            _memberRepository.Update(member);
        }

        public List<MemberListViewModel> GetAllMembers()
        {
            List<Member> membersDb = _memberRepository.GetAll();
            return membersDb.Select(m => m.ToMemberListViewModel()).ToList();
        }

        public MemberDetailsViewModel GetMemberDetails(int id)
        {
            Member memberDb = _memberRepository.GetById(id);
            return memberDb.ToMemberDetailsViewModel();
        }

        public AddMemberViewModel GetMemberForEditing(int id)
        {
            Member member = _memberRepository.GetById(id);
            return member.ToAddMemberViewModel();
        }
        public List<BookReservationsDDViewModel> GetBookReservationsDD(int memberId)
        {
            Member member = _memberRepository.GetById(memberId);
            List<BookReservationsDDViewModel> bookReservations = member.BookReservations.Select(br => br.ToBookReservationsDDViewModel()).ToList();
            return bookReservations;
        }
        public void DeteleBookAndReservation(int reservationId, int memberId)
        {
            BookReservation bookReservation = _bookReservationRepository.GetById(reservationId);
            _reservationRepository.DeleteById(bookReservation.ReservationId);
            _bookReservationRepository.DeleteById(bookReservation.Id);
            Member member = _memberRepository.GetById(memberId);
            member.BookReservations.Remove(bookReservation);
        }
    }
}
