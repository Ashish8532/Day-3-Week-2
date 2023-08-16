using E_Commerce.Models;

namespace E_Commerce.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> Update(Product obj);

        Task<List<Product>> GetProductByCategory(int categoryId);
    }
}
