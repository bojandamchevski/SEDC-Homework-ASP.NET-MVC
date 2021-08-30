using BojanDamchevski.BookLibraryApp.DataAccess.Implementations;
using BojanDamchevski.BookLibraryApp.DataAccess.Interfaces;
using BojanDamchevski.BookLibraryApp.Domain.Models;
using BojanDamchevski.BookLibraryApp.Services.Implementations;
using BojanDamchevski.BookLibraryApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BojanDamchevski.BookLibraryApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Member>, MemberRepository>();
            services.AddTransient<IRepository<Book>, BookRepository>();
            services.AddTransient<IRepository<Author>, AuthorRepository>();
            services.AddTransient<IRepository<Reservation>, ReservationRepository>();
            services.AddTransient<IRepository<BookReservation>, BookReservationRepository>();

        }
    }
}
