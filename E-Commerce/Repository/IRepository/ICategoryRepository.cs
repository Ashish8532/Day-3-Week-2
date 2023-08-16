using E_Commerce.Models;

namespace E_Commerce.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> Update(Category obj);
    }
}
