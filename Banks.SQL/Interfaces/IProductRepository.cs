using Banks.SQL.Product;

namespace Banks.SQL.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product.Product>> GetAllProductsAsync();
        Task AddProductAsync(Product.Product product);
        Task<Product.Product?> GetProductByIdAsync(Guid productId);
        Task UpdateProductAsync(Product.Product product);
        Task DeleteProductAsync(Guid productId);
    }
}
