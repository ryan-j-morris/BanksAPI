using Banks.SQL.Bank;
using Banks.SQL.Interfaces;
using BanksAPI.Interfaces;

namespace BanksAPI.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBranchRepository _branchRepository;
        public BankService(
            IBankRepository bankRepository,
            IBranchRepository branchRepository)
        {
            _bankRepository = bankRepository;
            _branchRepository = branchRepository;
        }

        public async Task<List<Bank>> GetAllBanksAsync()
        {
            return await _bankRepository.GetAllBanksAsync();
        }

        public async Task<Bank?> GetBankByIdAsync(Guid bankId)
        {
            return await _bankRepository.GetBankByIdAsync(bankId);
        }

        public async Task AddBankAsync(Bank bank)
        {
            await _bankRepository.AddBankAsync(bank);
        }

        public async Task UpdateBankAsync(Bank bank)
        {
            await _bankRepository.UpdateBankAsync(bank);
        }

        public async Task DeleteBankAsync(Guid bankId)
        {
            await _bankRepository.DeleteBankAsync(bankId);
        }

        public async Task<List<Branch>> GetAllBranchesAsync()
        {
            return await _branchRepository.GetAllBranchesAsync();
        }

        public async Task<Branch?> GetBranchByIdAsync(Guid branchId)
        {
            return await _branchRepository.GetBranchByIdAsync(branchId);
        }

        public async Task AddBranchAsync(Branch branch)
        {
            await _branchRepository.AddBranchAsync(branch);
        }

        public async Task UpdateBranchAsync(Branch branch)
        {
            await _branchRepository.UpdateBranchAsync(branch);
        }

        public async Task DeleteBranchAsync(Guid branchId)
        {
            await _branchRepository.DeleteBranchAsync(branchId);
        }
    }
}
