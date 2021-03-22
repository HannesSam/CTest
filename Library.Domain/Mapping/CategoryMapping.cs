using Library.Domain.DTOs;
using Library.Domain.Entities;
using Library.Domain.MappingInterfaces;

namespace Library.Domain.Mapping
{
    public class CategoryMapping : ICategoryMapping
    {
        public CategoryDTO CategoryToCategoryDTO(Category category)
        {
            return new CategoryDTO() { Id = category.Id, CategoryName = category.CategoryName };
        }

        public Category CategoryDTOToCategory(CategoryDTO categoryDTO)
        {
            return new Category() { Id = categoryDTO.Id, CategoryName = categoryDTO.CategoryName };
        }
    }
}
