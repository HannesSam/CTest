using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.ServiceInterfaces
{
    public interface ILibraryItemService
    {
        List<LibraryItem> GetLibraryItems();
        void AddLibraryItem(LibraryItem libraryItem);
        bool BorrowLibraryItem(LibraryItem libraryItem);
        void DeleteLibraryItem(LibraryItem libraryItem);
        bool ReturnLibraryItem(LibraryItem libraryItem);
        void UpdateLibraryItem(LibraryItem libraryItem);
    }
}