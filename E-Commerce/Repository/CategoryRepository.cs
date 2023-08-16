using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Repository.IRepository;

namespace E_Commerce.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Category> Update(Category obj)
        {
            _context.Categories.Update(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
    }
}
