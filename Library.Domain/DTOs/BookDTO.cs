using Library.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Domain.DTOs
{
    public class BookDTO : LibraryItemDTO
    {
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Pages has to be a positive number")]
        public int? Pages { get; set; }
        [Required]
        public bool IsBorrowable { get; set; } = true;
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.Book;
    }
}
