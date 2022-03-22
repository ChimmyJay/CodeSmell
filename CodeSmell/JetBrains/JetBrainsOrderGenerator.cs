using System.Collections.Generic;
using System.Linq;

namespace CodeSmell.JetBrains
{
    public class JetBrainsOrderGenerator
    {
        private readonly decimal _faxRate;

        public JetBrainsOrderGenerator() : this(0.05m)
        {
        }

        public JetBrainsOrderGenerator(decimal faxRate)
        {
            _faxRate = faxRate;
        }

        private readonly Dictionary<EnumProduct, decimal> _priceLookup = new()
        {
            { EnumProduct.Rider, 13.9m },
            { EnumProduct.WebStorm, 5.9m },
            { EnumProduct.Resharper, 12.9m },
            { EnumProduct.GoLand, 11.9m },
            { EnumProduct.PhpStorm, 11.9m },
            { EnumProduct.IntelliJ_IDEA_Ultimate, 19.9m }
        };

        public JetBrainsOrder Generate(
            EnumSubscriptionType subscriptionType,
            string userName,
            string userEmail,
            IEnumerable<EnumProduct> products)
        {
            return new JetBrainsOrder(_faxRate)
            {
                SubscriptionType = subscriptionType,
                Products = products.Select(x => new ProductPrice(x, _priceLookup[x])),
                UserName = userName,
                UserEmail = userEmail
            };
        }
    }
}