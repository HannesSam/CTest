using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.ServiceInterfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        Category GetCategoryById(int id);
        void UpdateCategory(Category category);
    }
}