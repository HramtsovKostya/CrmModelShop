using CrmBL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopModel
    {
        private readonly Generator Generator = new Generator();
        private readonly Random rnd = new Random();
        private readonly List<Task> tasks = new List<Task>();
        private bool isWorking = false;

        public List<CashDesk> CashDesks { get; } 
        public Queue<Seller> Sellers { get; }
        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;

        public ShopModel()
        {
            CashDesks = new List<CashDesk>();
            Sellers = new Queue<Seller>();

            Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);

            foreach (var seller in Generator.Sellers)
                Sellers.Enqueue(seller);

            for (int i = 0; i < 3; i++)
            {
                var cashDesk = new CashDesk(CashDesks.Count + 1, Sellers.Dequeue(), null);
                CashDesks.Add(cashDesk);
            }
        }

        public void Start()
        {
            isWorking = true;

            tasks.Add(new Task(() => CreateCarts(10)));
            tasks.AddRange(CashDesks.Select(cashDesk => new Task(() 
                => CashDeskWork(cashDesk))));

            foreach (var task in tasks) task.Start();
        }

        public void Stop() => isWorking = false;

        private void CashDeskWork(CashDesk cashDesk)
        {
            while(isWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }
        
        private void CreateCarts(int customerCounts)
        {
            while (isWorking)
            {
                Generator.GetNewCustomers(customerCounts);

                foreach (var customer in Generator.Customers)
                {
                    var cart = new Cart(customer);

                    foreach (var product in Generator.GetRandomProducts(10, 30))
                        cart.Add(product);

                    var cashDesk = CashDesks[rnd.Next(CashDesks.Count)];
                    cashDesk.Enqueue(cart);
                }
                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}