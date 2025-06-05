using Banks.SQL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks.SQL.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        BanksContextFactory _contextFactory = new BanksContextFactory();
        BanksContext _context;

        public BranchRepository()
        {
            _context = _contextFactory.CreateDbContext(Array.Empty<string>());
        }

        public async Task<List<Bank.Branch>> GetAllBranchesAsync()
        {
            using (_context)
            {
                return await _context.Branches.ToListAsync();
            }
        }
    
        public async Task AddBranchAsync(Bank.Branch branch)
        {
            using (_context)
            {
                _context.Branches.Add(branch);
                await _context.SaveChangesAsync();
            }
        }
    
        public async Task<Bank.Branch?> GetBranchByIdAsync(Guid branchId)
        {
            using (_context)
            {
                return await _context.Branches.FindAsync(branchId);
            }
        }
    
        public async Task UpdateBranchAsync(Bank.Branch branch)
        {
            using (_context)
            {
                _context.Branches.Update(branch);
                await _context.SaveChangesAsync();
            }
        }
    
        public async Task DeleteBranchAsync(Guid branchId)
        {
            using (_context)
            {
                var branch = await _context.Branches.FindAsync(branchId);
                if (branch != null)
                {
                    _context.Branches.Remove(branch);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
