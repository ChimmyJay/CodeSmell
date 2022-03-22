using System;
using System.Collections.Generic;
using CodeSmell.JetBrains;

namespace CodeSmell
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new JetBrainsOrderGenerator()
                .Generate(
                    subscriptionType: EnumSubscriptionType.Monthly,
                    userName: "chimm9Jay",
                    userEmail: "chimm9Jay@gmail.com",
                    products: new List<EnumProduct>
                    {
                        EnumProduct.Rider,
                        EnumProduct.WebStorm
                    });
            Print(order);
        }

        /// <summary>
        /// Print JetBrains order 
        /// </summary>
        /// <param name="order"></param>
        private static void Print(JetBrainsOrder order)
        {
            Console.WriteLine("------------------------------------------");

            //Print Subscription Type
            Console.WriteLine($@"Subscription type: '{order.SubscriptionType}' ");

            Console.WriteLine("------------------------------------------");

            //Print Each Product Price
            Console.WriteLine("Product         || Item Price ");
            foreach (var product in order.Products)
            {
                Console.WriteLine("{0,-16}|| {1,6} USD  ", product.Name, product.Price);
            }

            Console.WriteLine("------------------------------------------");

            //Print Total Price
            Console.WriteLine("{0,30}", $"Total Price    {order.GetTotalPrice()} USD");
            Console.WriteLine("{0,30}", $"Tax(5%)   {GetTax(order)} USD");
            Console.WriteLine("{0,30}", $"Grand Total   {GetGrandTotal(order)} USD");

            Console.WriteLine("------------------------------------------");

            //Print Licensee Information
            Console.WriteLine("Licensee information");
            Console.WriteLine($"UserName : {order.UserName}");
            Console.WriteLine($"Email : {order.UserEmail}");

            Console.WriteLine("------------------------------------------");
        }

        private static decimal GetTax(JetBrainsOrder order)
        {
            return order.GetTotalPrice() * order.FaxRate;
        }

        private static decimal GetGrandTotal(JetBrainsOrder order)
        {
            return order.GetTotalPrice() * (order.FaxRate + 1);
        }
    }
}