using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks.SQL.Product
{
    public class Issue : Base.BaseObject
    {
        public Guid IssueId { get; set; }
        public Guid ProductId { get; set; }
        public int IssueNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal InterestRate { get; set; } = 0.0m;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual Product? Product { get; set; }
    }
}
