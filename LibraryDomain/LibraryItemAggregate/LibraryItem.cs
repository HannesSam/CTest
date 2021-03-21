using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.LibraryItemAggregate
{
    public class LibraryItem
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Pages { get; set; }
        public int? RunTimeMinutes { get; set; }
        public bool IsBorrowable { get; set; }
        public string Borrower { get; set; }
        public DateTime? BorrowDate { get; set; }
        public LibraryItemType Type { get; set; }
    }

    public enum LibraryItemType
    {
        Book,
        DVD,
        AudioBook,
        ReferenceBook

    }
}
