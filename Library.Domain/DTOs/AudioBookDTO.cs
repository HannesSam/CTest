using Library.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Domain.DTOs
{
    public class AudioBookDTO : LibraryItemDTO
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Runtime has to be a positive number")]
        public int? RuntTimeMinutes { get; set; }
        [Required]
        public bool IsBorrowable { get; set; } = true;
        [Required]
        public LibraryItemType Type { get; set; } = LibraryItemType.AudioBook;
    }
}
