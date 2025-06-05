using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks.SQL.Bank
{
    public class Branch : Base.BaseObject
    {
        public Guid BranchId { get; set; }
        public Guid BankId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string SortCode { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public virtual Bank? Bank { get; set; }

    }
}
