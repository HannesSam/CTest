using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities
{
    public class LibraryItem
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        // Ej mappad då denna endast används i display syften. Vi vill även alltid hämta det senaste namnet på kategorin ifall en ändring har skett i den databasen.
        [NotMapped]
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Pages { get; set; }
        public int? RunTimeMinutes { get; set; }
        public bool IsBorrowable { get; set; }
        public string Borrower { get; set; }
        public DateTime? BorrowDate { get; set; }
        public LibraryItemType Type { get; set; }
    }

}
