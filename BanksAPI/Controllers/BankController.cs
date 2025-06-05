using Banks.SQL.Bank;
using BanksAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BanksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet("banks")]
        public async Task<IActionResult> GetAllBanks()
        {
            var banks = await _bankService.GetAllBanksAsync();
            return Ok(banks);
        }

        [HttpGet("banks/{id}")]
        public async Task<IActionResult> GetBankById(Guid id)
        {
            var bank = await _bankService.GetBankByIdAsync(id);
            if (bank == null)
            {
                return NotFound();
            }
            return Ok(bank);
        }

        [HttpPost("banks")]
        public async Task<IActionResult> AddBank([FromBody] Bank bank)
        {
            await _bankService.AddBankAsync(bank);
            return CreatedAtAction(nameof(GetBankById), new { id = bank.BankId }, bank);
        }

        [HttpPut("banks/{id}")]
        public async Task<IActionResult> UpdateBank(Guid id, [FromBody] Bank bank)
        {
            if (id != bank.BankId)
            {
                return BadRequest();
            }
            await _bankService.UpdateBankAsync(bank);
            return NoContent();
        }

        [HttpDelete("banks/{id}")]
        public async Task<IActionResult> DeleteBank(Guid id)
        {
            await _bankService.DeleteBankAsync(id);
            return NoContent();
        }

        [HttpGet("branches")]
        public async Task<IActionResult> GetAllBranches()
        {
            var branches = await _bankService.GetAllBranchesAsync();
            return Ok(branches);
        }

        [HttpGet("branches/{id}")]
        public async Task<IActionResult> GetBranchById(Guid id)
        {
            var branch = await _bankService.GetBranchByIdAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }

        [HttpPost("branches")]
        public async Task<IActionResult> AddBranch([FromBody] Branch branch)
        {
            await _bankService.AddBranchAsync(branch);
            return CreatedAtAction(nameof(GetBranchById), new { id = branch.BranchId }, branch);
        }

        [HttpPut("branches/{id}")]
        public async Task<IActionResult> UpdateBranch(Guid id, [FromBody] Branch branch)
        {
            if (id != branch.BranchId)
            {
                return BadRequest();
            }
            await _bankService.UpdateBranchAsync(branch);
            return NoContent();
        }

        [HttpDelete("branches/{id}")]
        public async Task<IActionResult> DeleteBranch(Guid id)
        {
            await _bankService.DeleteBranchAsync(id);
            return NoContent();
        }
    }
}
