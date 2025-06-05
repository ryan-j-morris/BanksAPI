using Banks.SQL.Bank;

namespace BanksAPI.Interfaces
{
    public interface IBankService
    {
        Task<List<Bank>> GetAllBanksAsync();
        Task<Bank?> GetBankByIdAsync(Guid bankId);
        Task AddBankAsync(Bank bank);
        Task UpdateBankAsync(Bank bank);
        Task DeleteBankAsync(Guid bankId);
        Task<List<Branch>> GetAllBranchesAsync();
        Task<Branch?> GetBranchByIdAsync(Guid branchId);
        Task AddBranchAsync(Branch branch);
        Task UpdateBranchAsync(Branch branch);
        Task DeleteBranchAsync(Guid branchId);

    }
}
