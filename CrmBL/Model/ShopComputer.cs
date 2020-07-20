using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class ShopComputer
    {
        private readonly Generator Generator;
        private readonly Random rnd = new Random();

        public List<CashDesk> CashDesks { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Check> Checks { get; set; }

        public List<Sell> Sells { get; set; }

        public Queue<Seller> Sellers { get; set; }

        public ShopComputer()
        {
            CashDesks = new List<CashDesk>();
            Carts = new List<Cart>();
            Checks = new List<Check>();
            Sells = new List<Sell>();
            Sellers = new Queue<Seller>();
            Generator = new Generator();

            Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(100);

            foreach (var seller in Generator.Sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++)
            {
                var cashDesk = new CashDesk(CashDesks.Count, Sellers.Dequeue());
                CashDesks.Add(cashDesk);
            }
        }

        public void Start()
        {
            var customers = Generator.GetNewCustomers(10);
            var carts = new Queue<Cart>();

            foreach (var customer in customers)
            {
                var cart = new Cart(customer);
                var products = Generator.GetRandomProducts(10, 30);

                foreach (var product in products)
                {
                    cart.Add(product);
                }
                carts.Enqueue(cart);
            }

            while (carts.Count > 0)
            {
                var index = rnd.Next(CashDesks.Count - 1);
                var cashDesk = CashDesks[index];

                cashDesk.Enqueue(carts.Dequeue());
            }

            while (CashDesks.Count > 0)
            {
                var index = rnd.Next(CashDesks.Count - 1);
                var cashDesk = CashDesks[index];

                cashDesk.Dequeue();
            }
        }
    }
}