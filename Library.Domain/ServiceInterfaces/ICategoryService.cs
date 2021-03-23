using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.ServiceInterfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        bool AddCategory(Category category);
        void DeleteCategory(Category category);
        Category GetCategoryById(int id);
        bool UpdateCategory(Category category);
    }
}