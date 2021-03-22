using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Infrastructure
{
    class LibraryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite(@"Data Source=C:\sqlLite\Library.db");

        #region
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seedar databasen så att det finns något från start.
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CategoryName = "Fantasy"
                },
                new Category()
                {
                    Id = 2,
                    CategoryName = "Romance"
                },
                 new Category()
                 {
                     Id = 3,
                     CategoryName = "Thriller"
                 }
                );

            modelBuilder.Entity<LibraryItem>().HasData(
                new LibraryItem()
                {
                    Id = 1,
                    Title = "The Lord of the Rings",
                    Author = "JRR Tolkien",
                    Pages = 978,
                    IsBorrowable = true,
                    Type = LibraryItemType.Book,
                    CategoryId = 1
                },
                new LibraryItem()
                {
                    Id = 2,
                    Title = "Mandalorian",
                    RunTimeMinutes = 125,
                    IsBorrowable = true,
                    Type = LibraryItemType.DVD,
                    CategoryId = 2
                },
                new LibraryItem()
                {
                    Id = 3,
                    Title = "Harry Potter Saves The Day Again",
                    Author = "JK Rowling",
                    RunTimeMinutes = 230,
                    IsBorrowable = true,
                    Type = LibraryItemType.AudioBook,
                    CategoryId = 1
                },
                new LibraryItem()
                {
                    Id = 4,
                    Title = "Sapiens",
                    Author = "Yuval Noah Harari",
                    Pages = 450,
                    IsBorrowable = false,
                    Type = LibraryItemType.ReferenceBook,
                    CategoryId = 3
                },
                new LibraryItem()
                {
                    Id = 5,
                    Title = "The Irishman",
                    RunTimeMinutes = 25555,
                    IsBorrowable = true,
                    Type = LibraryItemType.DVD,
                    CategoryId = 2,
                    Borrower = "Hannes Samskog",
                    BorrowDate = DateTime.Now
                }); ;

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}

