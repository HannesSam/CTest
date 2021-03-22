using Library.Domain.Entities;
using Library.Domain.Repositorys;
using Library.Domain.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Services
{
    public class LibraryItemService : ILibraryItemService
    {
        readonly ILibraryItemRepository _db;
        public LibraryItemService(ILibraryItemRepository db)
        {
            _db = db;
        }

        public List<LibraryItem> GetLibraryItems()
        {
            return _db.LibraryItems.ToList(); ;
        }
        public void AddLibraryItem(LibraryItem libraryItem)
        {
            _db.AddLibraryItem(libraryItem);
        }

        public void UpdateLibraryItem(LibraryItem libraryItem)
        {
            _db.UpdateLibraryItem(libraryItem);
        }

        public void DeleteLibraryItem(LibraryItem libraryItem)
        {
            _db.DeleteLibraryItem(libraryItem);
        }

        public bool BorrowLibraryItem(LibraryItem libraryItem)
        {
            LibraryItem dbLibraryItem = _db.LibraryItems.FirstOrDefault(item => item.Id == libraryItem.Id);

            if (dbLibraryItem == null)
            {
                return false;
            }

            //Check that no borrower exists
            if (dbLibraryItem.IsBorrowable == true)
            {
                libraryItem.BorrowDate = DateTime.Now;
                _db.UpdateLibraryItem(libraryItem);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ReturnLibraryItem(LibraryItem libraryItem)
        {
            LibraryItem dbLibraryItem = _db.LibraryItems.FirstOrDefault(item => item.Id == libraryItem.Id);

            if (dbLibraryItem == null)
            {
                return false;
            }

            if (dbLibraryItem.Borrower.ToLower() == libraryItem.Borrower.ToLower())
            {
                dbLibraryItem.Borrower = null;
                dbLibraryItem.BorrowDate = null;
                _db.UpdateLibraryItem(dbLibraryItem);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
