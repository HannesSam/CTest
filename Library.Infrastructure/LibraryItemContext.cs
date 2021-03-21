using LibraryDomain.LibraryItemAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class LibraryItemContext : DbContext
    {
        public DbSet<LibraryItem> LibraryItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite(@"Data Source=C:\sqlLite\LibraryItems.db");
    }

    public class LibraryItemRepository : ILibraryItemRepository
    {
        readonly LibraryItemContext _db;
        public LibraryItemRepository()
        {
            _db = new LibraryItemContext();
        }

        public IQueryable<LibraryItem> LibraryItems => _db.LibraryItems;
        public IQueryable<Category> Categories => _db.Categories;

        public bool AddCategory(Category category)
        {
            _db.Categories.Add(category);
            return true;
        }

        public bool AddLibraryItem(LibraryItem libraryItem)
        {
            _db.Add(libraryItem);
            _db.SaveChanges();
            return true;
        }


        public bool DeleteLibraryItem(LibraryItem libraryItem)
        {
            //var itemToRemove = new LibraryItem { Id = id };
            _db.Remove(libraryItem);
            _db.SaveChanges();
            return true;
        }



        public bool UpdateLibraryItem(LibraryItem libraryItem)
        {
            LibraryItem itemToUpdate = _db.LibraryItems.FirstOrDefault(item => item.Id == libraryItem.Id);

            if (itemToUpdate != null)
            {
                itemToUpdate.Author = libraryItem.Author;
                itemToUpdate.Category = libraryItem.Category;
                itemToUpdate.Pages = libraryItem.Pages;
                itemToUpdate.RunTimeMinutes = libraryItem.RunTimeMinutes;
                itemToUpdate.Title = libraryItem.Title;
                itemToUpdate.Borrower = libraryItem.Borrower;

                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}