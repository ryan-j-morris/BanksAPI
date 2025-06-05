using Banks.SQL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks.SQL.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        BanksContextFactory _contextFactory = new BanksContextFactory();
        BanksContext _context;

        public IssueRepository()
        {
            _context = _contextFactory.CreateDbContext(Array.Empty<string>());
        }

        public async Task<List<Product.Issue>> GetAllIssuesAsync()
        {
            using (_context)
            {
                return await _context.Issues.ToListAsync();
            }
        }

        public async Task AddIssueAsync(Product.Issue issue)
        {
            using (_context)
            {
                _context.Issues.Add(issue);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Product.Issue?> GetIssueByIdAsync(Guid issueId)
        {
            using (_context)
            {
                return await _context.Issues.FindAsync(issueId);
            }
        }

        public async Task UpdateIssueAsync(Product.Issue issue)
        {
            using (_context)
            {
                _context.Issues.Update(issue);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteIssueAsync(Guid issueId)
        {
            using (_context)
            {
                var issue = await _context.Issues.FindAsync(issueId);
                if (issue != null)
                {
                    _context.Issues.Remove(issue);
                    await _context.SaveChangesAsync();
                }
            }

        }
    }
}
