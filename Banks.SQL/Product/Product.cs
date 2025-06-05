

namespace Banks.SQL.Product
{
    public class Product : Base.BaseObject
    {
        public Guid ProductId { get; set; }
        public Guid BankId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public virtual Bank.Bank? Bank { get; set; }
    }
}
