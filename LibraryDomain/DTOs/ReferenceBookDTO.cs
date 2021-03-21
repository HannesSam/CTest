using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.DTOs
{
    class ReferenceBookDTO : LibraryItemDTO
    {
        [Required]
        public string Author { get; set; }
        [Required]
        public int? Pages { get; set; }
        [Required]
        public bool IsBorrowable { get; set; } = false;
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.ReferenceBook;
    }
}
