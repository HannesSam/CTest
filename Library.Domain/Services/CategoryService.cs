using Library.Domain.Entities;
using Library.Domain.Repositorys;
using Library.Domain.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        readonly ICategoryRepository _db;
        public CategoryService(ICategoryRepository db)
        {
            _db = db;
        }

        public Category GetCategoryById(int id)
        {
            return _db.GetCategoryById(id);
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        }
        public bool AddCategory(Category category)
        {
            if (!_db.Categories.Where(c => c.CategoryName.ToLower() == category.CategoryName.ToLower()).Any())
            {
                _db.AddCategory(category);
                return true;
            }
            return false;
        }

        public bool UpdateCategory(Category category)
        {
            if (!_db.Categories.Where(c => c.CategoryName.ToLower() == category.CategoryName.ToLower()).Any())
            {
                _db.UpdateCategory(category);
                return true;
            }
            return false;
        }

        // Här borde kod för att ta bort en kategori ligga men nu ligger den i web delen av applikationen då det skulle ta en större refactoring för att få den att funka här.
        public void DeleteCategory(Category category)
        {
            _db.DeleteCategory(category);
        }

    }
}
