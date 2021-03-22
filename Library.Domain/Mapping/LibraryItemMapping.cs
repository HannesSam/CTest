using Library.Domain.DTOs;
using Library.Domain.Entities;
using Library.Domain.MappingInterfaces;

namespace Library.Domain.Mapping
{
    /// <summary>
    /// En klass som används för att mappa värden mellan LibraryItem och våra DTOs som används för att skicka specifik data för de olika typerna. 
    /// Detta kan såklart göras med hjälp av automatiska mapping verktyg men tänkte på det först när jag redan var färdig. 
    /// </summary>
    public class LibraryItemMapping : ILibraryItemMapping
    {
        public BookDTO LibraryItemToBook(LibraryItem libraryItem)
        {
            return new BookDTO() { CategoryName = libraryItem.CategoryName, Id = libraryItem.Id, Author = libraryItem.Author, Title = libraryItem.Title, Pages = libraryItem.Pages, Type = libraryItem.Type, IsBorrowable = libraryItem.IsBorrowable };
        }

        public LibraryItem BookToLibraryItem(BookDTO book)
        {
            return new LibraryItem() { CategoryName = book.CategoryName, Id = book.Id, Author = book.Author, Title = book.Title, Pages = book.Pages, Type = book.Type, IsBorrowable = book.IsBorrowable };
        }

        public AudioBookDTO LibraryItemToAudioBook(LibraryItem libraryItem)
        {
            return new AudioBookDTO() { CategoryName = libraryItem.CategoryName, Id = libraryItem.Id, RuntTimeMinutes = libraryItem.RunTimeMinutes, Title = libraryItem.Title, Type = libraryItem.Type, IsBorrowable = libraryItem.IsBorrowable };
        }

        public LibraryItem AudioBookToLibraryItem(AudioBookDTO audioBook)
        {
            return new LibraryItem() { CategoryName = audioBook.CategoryName, Id = audioBook.Id, RunTimeMinutes = audioBook.RuntTimeMinutes, Title = audioBook.Title, Type = audioBook.Type, IsBorrowable = audioBook.IsBorrowable };
        }

        public DVDDTO LibraryItemToDVD(LibraryItem libraryItem)
        {
            return new DVDDTO() { CategoryName = libraryItem.CategoryName, Id = libraryItem.Id, RuntTimeMinutes = libraryItem.RunTimeMinutes, Title = libraryItem.Title, Type = libraryItem.Type, IsBorrowable = libraryItem.IsBorrowable };
        }

        public LibraryItem DVDToLibraryItem(DVDDTO dvd)
        {
            return new LibraryItem() { CategoryName = dvd.CategoryName, Id = dvd.Id, RunTimeMinutes = dvd.RuntTimeMinutes, Title = dvd.Title, Type = dvd.Type, IsBorrowable = dvd.IsBorrowable };
        }

        public ReferenceBookDTO LibraryItemToReferenceBook(LibraryItem libraryItem)
        {
            return new ReferenceBookDTO() { CategoryName = libraryItem.CategoryName, Id = libraryItem.Id, Author = libraryItem.Author, Pages = libraryItem.Pages, Title = libraryItem.Title, Type = libraryItem.Type, IsBorrowable = libraryItem.IsBorrowable };
        }

        public LibraryItem ReferenceBookToLibraryItem(ReferenceBookDTO referenceBook)
        {
            return new LibraryItem() { CategoryName = referenceBook.CategoryName, Id = referenceBook.Id, Author = referenceBook.Author, Pages = referenceBook.Pages, Title = referenceBook.Title, Type = referenceBook.Type, IsBorrowable = referenceBook.IsBorrowable };
        }
    }
}
