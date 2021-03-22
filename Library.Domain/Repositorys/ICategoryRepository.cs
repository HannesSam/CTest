using Library.Domain.Entities;
using System.Linq;

namespace Library.Domain.Repositorys
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
        public Category GetCategoryById(int id);
        public bool AddCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(Category category);
    }
}
