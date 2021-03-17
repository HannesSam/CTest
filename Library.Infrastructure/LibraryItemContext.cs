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
        public bool AddLibraryItem(LibraryItem libraryItem)
        {

            _db.Add(new LibraryItem { Title = "Hej" });

            _db.SaveChanges();

            return true;
        }
    }
}
