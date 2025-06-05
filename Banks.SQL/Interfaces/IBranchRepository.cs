using Banks.SQL.Bank;

namespace Banks.SQL.Interfaces
{
    public interface IBranchRepository
    {
        Task<List<Branch>> GetAllBranchesAsync();
        Task AddBranchAsync(Branch branch);
        Task<Branch?> GetBranchByIdAsync(Guid branchId);
        Task UpdateBranchAsync(Branch branch);
        Task DeleteBranchAsync(Guid branchId);
    }
}
