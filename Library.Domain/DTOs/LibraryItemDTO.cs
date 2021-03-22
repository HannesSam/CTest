using System.ComponentModel.DataAnnotations;

namespace Library.Domain.DTOs
{
    /// <summary>
    /// Basklass för alla DTOs för att undvika att deklarera vissa properties i alla klasser.
    /// </summary>
    public class LibraryItemDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
