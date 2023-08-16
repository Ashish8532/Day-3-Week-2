using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<Product> Update(Product obj)
        {
            _context.Products.Update(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<List<Product>> GetProductByCategory(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
