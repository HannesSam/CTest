using Library.Domain.DTOs;
using Library.Domain.Entities;

namespace Library.Domain.MappingInterfaces
{
    public interface ILibraryItemMapping
    {
        LibraryItem AudioBookToLibraryItem(AudioBookDTO audioBook);
        LibraryItem BookToLibraryItem(BookDTO book);
        LibraryItem DVDToLibraryItem(DVDDTO dvd);
        AudioBookDTO LibraryItemToAudioBook(LibraryItem libraryItem);
        BookDTO LibraryItemToBook(LibraryItem libraryItem);
        DVDDTO LibraryItemToDVD(LibraryItem libraryItem);
        ReferenceBookDTO LibraryItemToReferenceBook(LibraryItem libraryItem);
        LibraryItem ReferenceBookToLibraryItem(ReferenceBookDTO referenceBook);
    }
}