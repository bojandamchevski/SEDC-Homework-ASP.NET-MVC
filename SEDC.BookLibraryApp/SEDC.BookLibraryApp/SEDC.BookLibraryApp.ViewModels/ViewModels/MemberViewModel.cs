using System;
using System.Collections.Generic;

namespace SEDC.BookLibraryApp.ViewModels.ViewModels
{
    public class MemberViewModel
    {
        public string MemberFullName { get; set; }
        public Dictionary<string, string> BooksAndAuthors { get; set; }
        public List<DateTime> Reservations { get; set; }
    }
}
