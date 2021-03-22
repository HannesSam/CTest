using Library.Domain.Entities;
using Library.Domain.Repositorys;
using System.Linq;

namespace Library.Infrastructure
{
    /// <summary>
    /// Repository för alla katergorier
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        readonly LibraryContext _db;
        public CategoryRepository()
        {
            _db = new LibraryContext();
        }
        public IQueryable<Category> Categories => _db.Categories;

        public Category GetCategoryById(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }
        public bool AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChangesAsync();
            return true;
        }

        public bool DeleteCategory(Category category)
        {
            _db.Remove(category);
            _db.SaveChangesAsync();
            return true;
        }

        public bool UpdateCategory(Category category)
        {
            Category itemToUpdate = _db.Categories.FirstOrDefault(item => item.Id == category.Id);

            if (itemToUpdate != null)
            {
                itemToUpdate.CategoryName = category.CategoryName;

                _db.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
