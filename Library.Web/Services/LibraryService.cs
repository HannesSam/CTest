using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDomain.LibraryItemAggregate;

namespace Library.Web.Services
{
    public class LibraryService
    {
        ILibraryItemRepository _libraryService;
        public LibraryService(ILibraryItemRepository libraryService)
        {
            _libraryService = libraryService;
        }

        public List<LibraryItem> GetLibraryItems()
        {
            return _libraryService.LibraryItems.ToList();
        }
        public void AddLibraryItem(LibraryItem libraryItem)
        {
            _libraryService.AddLibraryItem(libraryItem);
        }
    }
}
