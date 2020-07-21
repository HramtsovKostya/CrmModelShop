using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Generator
    {
        private readonly Random rnd = new Random();

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public List<Product> Products { get; set; } = new List<Product>();

        public Generator() { }

        public void GetNewCustomers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count + 1,
                    Name = GetRandomText()
                };
                Customers.Add(customer);
            }
        }

        public void GetNewSellers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count + 1,
                    Name = GetRandomText()
                };
                Sellers.Add(seller);
            }
        }

        public void GetNewProducts(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count + 1,
                    Name = GetRandomText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 100000) + rnd.NextDouble())
                };
                Products.Add(product);
            }
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);

            for (int i = 0; i < count; i++)
                result.Add(Products[rnd.Next(Products.Count - 1)]);
            return result;
        }

        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}