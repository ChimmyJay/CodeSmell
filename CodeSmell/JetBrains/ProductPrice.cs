namespace CodeSmell.JetBrains
{
    public class ProductPrice
    {
        public ProductPrice(EnumProduct name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public EnumProduct Name { get; }
        public decimal Price { get; }
    }
}