using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.DTOs
{
    class AudioBookDTO : LibraryItemDTO
    {
        [Required]
        public string RuntTimeMinutes { get; set; }
        [Required]
        public bool IsBorrowable { get; set; } = true;
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.AudioBook;
    }
}
