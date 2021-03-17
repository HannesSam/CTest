using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Model
{
    public class DisplayLibraryItem
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title is too long please shorten it down to under 30 characters.")]
        public string Title { get; set; }
        [Required]
        public bool IsBorrowable { get; set; }
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.Book;
    }
}
