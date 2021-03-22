using System.ComponentModel.DataAnnotations;

namespace Library.Domain.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
