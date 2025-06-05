using Banks.SQL.Bank;

namespace Banks.SQL.Interfaces
{
    public interface IBankRepository
    {
        Task<List<Bank.Bank>> GetAllBanksAsync();
        Task AddBankAsync(Bank.Bank bank);
        Task<Bank.Bank?> GetBankByIdAsync(Guid bankId);
        Task UpdateBankAsync(Bank.Bank bank);
        Task DeleteBankAsync(Guid bankId);
    }
}
