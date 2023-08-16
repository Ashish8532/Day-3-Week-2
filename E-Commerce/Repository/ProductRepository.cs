using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Repository.IRepository;

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
    }
}
