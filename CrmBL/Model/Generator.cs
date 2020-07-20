using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Generator
    {
        private readonly Random rnd = new Random();

        public List<Customer> Customers { get; set; }

        public List<Product> Products { get; set; }

        public List<Seller> Sellers { get; set; }

        public Generator()
        {
            Customers = new List<Customer>();
            Products = new List<Product>();
            Sellers = new List<Seller>();
        }

        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText()
                };

                Customers.Add(customer);
                result.Add(customer);
            }
            return result;
        }

        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText()
                };

                Sellers.Add(seller);
                result.Add(seller);
            }
            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 100000) + rnd.NextDouble())
                };

                Products.Add(product);  
                result.Add(product);
            }
            return result;
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);

            for (int i = 0; i < count; i++)
            {
                var index = rnd.Next(Products.Count - 1);
                result.Add(Products[index]);
            }

            return result;
        }

        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}