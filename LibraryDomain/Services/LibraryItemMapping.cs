using LibraryDomain.DTOs;
using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.Services
{
    public class LibraryItemMapping
    {
        public static BookDTO LibraryItemToBook(LibraryItem libraryItem)
        {
            return new BookDTO() { Id = libraryItem.Id, Author = libraryItem.Author, Title = libraryItem.Title, Pages = libraryItem.Pages, Type = libraryItem.Type, IsBorrowable = libraryItem.IsBorrowable };
        }

        public static LibraryItem BookToLibraryItem(BookDTO book)
        {
            return new LibraryItem() { Id = book.Id, Author = book.Author, Title = book.Title, Pages = book.Pages, Type = book.Type };
        }
    }
}
