using Library.Domain.Entities;
using System.Linq;

namespace Library.Domain.Repositorys
{
    public interface ILibraryItemRepository
    {
        IQueryable<LibraryItem> LibraryItems { get; }
        public bool AddLibraryItem(LibraryItem libraryItem);
        public bool DeleteLibraryItem(LibraryItem libraryItem);
        public bool UpdateLibraryItem(LibraryItem libraryItem);
    }
}
