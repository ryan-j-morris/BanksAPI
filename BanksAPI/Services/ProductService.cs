using Banks.SQL.Interfaces;
using Banks.SQL.Product;

namespace BanksAPI.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IIssueRepository _issueRepository;

        public ProductService(
            IProductRepository productRepository,
            IIssueRepository issueRepository)
        {
            _productRepository = productRepository;
            _issueRepository = issueRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(Guid productId)
        {
            return await _productRepository.GetProductByIdAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
        }

        public async Task DeleteProductAsync(Guid productId)
        {
            await _productRepository.DeleteProductAsync(productId);
        }

        public async Task<List<Issue>> GetAllIssuesAsync()
        {
            return await _issueRepository.GetAllIssuesAsync();
        }

        public async Task<Issue?> GetIssueByIdAsync(Guid issueId)
        {
            return await _issueRepository.GetIssueByIdAsync(issueId);
        }

        public async Task AddIssueAsync(Issue issue)
        {
            await _issueRepository.AddIssueAsync(issue);
        }

        public async Task UpdateIssueAsync(Issue issue)
        {
            await _issueRepository.UpdateIssueAsync(issue);
        }

        public async Task DeleteIssueAsync(Guid issueId)
        {
            await _issueRepository.DeleteIssueAsync(issueId);
        }

    }
}
