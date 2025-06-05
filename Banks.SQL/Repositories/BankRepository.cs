using Banks.SQL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Banks.SQL.Repositories
{
    public class BankRepository : IBankRepository
    {
        BanksContextFactory _contextFactory = new BanksContextFactory();
        BanksContext _context;

        public BankRepository()
        {
            _context = _contextFactory.CreateDbContext(Array.Empty<string>());
        }

        public async Task<List<Bank.Bank>> GetAllBanksAsync()
        {
            using (_context)
            {
                return await _context.Banks.ToListAsync();
            }
        }

        public async Task AddBankAsync(Bank.Bank bank)
        {
            using (_context)
            {
                _context.Banks.Add(bank);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Bank.Bank?> GetBankByIdAsync(Guid bankId)
        {
            using (_context)
            {
                return await _context.Banks.FindAsync(bankId);
            }
        }

        public async Task UpdateBankAsync(Bank.Bank bank)
        {
            using (_context)
            {
                _context.Banks.Update(bank);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBankAsync(Guid bankId)
        {
            using (_context)
            {
                var bank = await _context.Banks.FindAsync(bankId);
                if (bank != null)
                {
                    _context.Banks.Remove(bank);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
