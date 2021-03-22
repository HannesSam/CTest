using Library.Domain.Entities;
using Library.Domain.Repositorys;
using System.Linq;

namespace Library.Infrastructure
{
    /// <summary>
    /// Repository för alla LibraryItems
    /// </summary>
    public class LibraryItemRepository : ILibraryItemRepository
    {
        readonly LibraryContext _db;
        public LibraryItemRepository()
        {
            _db = new LibraryContext();
        }

        public IQueryable<LibraryItem> LibraryItems => _db.LibraryItems;

        public bool AddLibraryItem(LibraryItem libraryItem)
        {
            _db.Add(libraryItem);
            _db.SaveChangesAsync();
            return true;
        }


        public bool DeleteLibraryItem(LibraryItem libraryItem)
        {
            _db.Remove(libraryItem);
            _db.SaveChangesAsync();
            return true;
        }



        public bool UpdateLibraryItem(LibraryItem libraryItem)
        {
            // Hämtar det item som ska uppdateras. 
            LibraryItem itemToUpdate = _db.LibraryItems.FirstOrDefault(item => item.Id == libraryItem.Id);

            if (itemToUpdate != null)
            {
                // Detta kan såklart mappas automatikst men jag gjorde det av någon anledning det lite bökigt för mig själv.
                itemToUpdate.Author = libraryItem.Author;
                itemToUpdate.CategoryId = libraryItem.CategoryId;
                itemToUpdate.Pages = libraryItem.Pages;
                itemToUpdate.RunTimeMinutes = libraryItem.RunTimeMinutes;
                itemToUpdate.Title = libraryItem.Title;
                itemToUpdate.Borrower = libraryItem.Borrower;

                _db.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}