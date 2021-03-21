using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.LibraryItemAggregate
{
    public interface ILibraryItemRepository
    {
        IQueryable<LibraryItem> LibraryItems { get; }
        IQueryable<Category> Categories { get; }
        public bool AddLibraryItem(LibraryItem libraryItem);
        public bool DeleteLibraryItem(LibraryItem libraryItem);
        public bool UpdateLibraryItem(LibraryItem libraryItem);
        public bool AddCategory(Category category);
       
    }
}
