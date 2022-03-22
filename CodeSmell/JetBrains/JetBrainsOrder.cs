using System.Collections.Generic;
using System.Linq;

namespace CodeSmell.JetBrains
{
    public class JetBrainsOrder
    {
        public JetBrainsOrder(decimal taxRate)
        {
            TaxRate = taxRate;
        }

        public decimal TaxRate { get; }
        public EnumSubscriptionType SubscriptionType { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public IEnumerable<ProductPrice> Products { get; set; }
        public decimal GetTotalPrice() => Products.Sum(x => x.Price);
    }
}