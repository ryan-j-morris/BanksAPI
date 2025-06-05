using Banks.SQL.Product;

namespace BanksAPI.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(Guid productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Guid productId);
        
        Task<List<Issue>> GetAllIssuesAsync();
        Task<Issue?> GetIssueByIdAsync(Guid issueId);
        Task AddIssueAsync(Issue issue);
        Task UpdateIssueAsync(Issue issue);
        Task DeleteIssueAsync(Guid issueId);
    }
}
