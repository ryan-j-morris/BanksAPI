using Banks.SQL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Banks.SQL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        BanksContextFactory _contextFactory = new BanksContextFactory();
        BanksContext _context;

        public ProductRepository()
        {
            _context = _contextFactory.CreateDbContext(Array.Empty<string>());
        }
        public async Task<List<Product.Product>> GetAllProductsAsync()
        {
            using (_context)
            {
                return await _context.Products.ToListAsync();
            }
        }
    
        public async Task AddProductAsync(Product.Product product)
        {
            using (_context)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
            }
        }
    
        public async Task<Product.Product?> GetProductByIdAsync(Guid productId)
        {
            using (_context)
            {
                return await _context.Products.FindAsync(productId);
            }
        }
    
        public async Task UpdateProductAsync(Product.Product product)
        {
            using (_context)
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
        }
    
        public async Task DeleteProductAsync(Guid productId)
        {
            using (_context)
            {
                var product = await _context.Products.FindAsync(productId);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
