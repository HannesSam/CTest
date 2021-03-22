using Library.Domain.DTOs;
using Library.Domain.Entities;

namespace Library.Domain.MappingInterfaces
{
    public interface ICategoryMapping
    {
        Category CategoryDTOToCategory(CategoryDTO categoryDTO);
        CategoryDTO CategoryToCategoryDTO(Category category);
    }
}