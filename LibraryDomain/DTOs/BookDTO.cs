using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.DTOs
{
    public class BookDTO : LibraryItemDTO
    {
        [Required]
        public string Author { get; set; }
        [Required]
        public int? Pages { get; set; }
        [Required]
        public bool IsBorrowable { get; set; } = true;
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.Book;
    }
}
