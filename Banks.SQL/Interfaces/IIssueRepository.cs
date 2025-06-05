using Banks.SQL.Product;

namespace Banks.SQL.Interfaces
{
    public interface IIssueRepository
    {
        Task<List<Issue>> GetAllIssuesAsync();
        Task AddIssueAsync(Issue issue);
        Task<Issue?> GetIssueByIdAsync(Guid issueId);
        Task UpdateIssueAsync(Issue issue);
        Task DeleteIssueAsync(Guid issueId);
    }
}
