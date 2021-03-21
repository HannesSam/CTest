using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDomain.DTOs;
using LibraryDomain.LibraryItemAggregate;

namespace LibraryDomain.Services
{
    public class LibraryService
    {
        ILibraryItemRepository _db;
        public LibraryService(ILibraryItemRepository db)
        {
            _db = db;
        }

        public List<LibraryItem> GetLibraryItems()
        {
            return _db.LibraryItems.ToList();
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
            if (dbLibraryItem.IsBorrowable == true )
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
                libraryItem.Borrower = null;
                libraryItem.BorrowDate = null;
                _db.UpdateLibraryItem(libraryItem);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

// foreach (var libraryItem in libraryItems)
//{
//    LibraryItemDTO libItemDTO;
//    switch (libraryItem.Type)
//    {
//        case LibraryItemType.Book:
//            BookDTO book = new BookDTO();
//            book.Author = libraryItem.Author;
//            libItemDTO = book;
//            break;
//        case LibraryItemType.DVD:
//            book = new BookDTO();
//            book.Author = libraryItem.Author;
//            libItemDTO = book;
//            break;
//        case LibraryItemType.AudioBook:
//            book = new BookDTO();
//            book.Author = libraryItem.Author;
//            libItemDTO = book;
//            break;
//        case LibraryItemType.ReferenceBook:
//            book = new BookDTO();
//            book.Author = libraryItem.Author;
//            libItemDTO = book;
//            break;
//        default:
//            book = new BookDTO();
//            book.Author = libraryItem.Author;
//            libItemDTO = book;
//            break;
//    }
//    libItemDTO.Title = libraryItem.Title;
//    libItemsDTO.Add(libItemDTO);