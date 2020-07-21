using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputer
    {
        private readonly Generator Generator = new Generator();
        private readonly Random rnd = new Random();
        private bool isWorking = false;

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputer()
        {
            Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);

            foreach (var seller in Generator.Sellers)
                Sellers.Enqueue(seller);

            for (int i = 0; i < 3; i++)
            {
                var cashDesk = new CashDesk(CashDesks.Count + 1, Sellers.Dequeue());
                CashDesks.Add(cashDesk);
            }
        }

        public void Start()
        {
            isWorking = true;
            Task.Run(() => CreateCarts(10, 1000));

            var cashDeskTasks = CashDesks.Select(cashDesk => new Task(() 
                => CashDeskWork(cashDesk, 1000)));

            foreach (var task in cashDeskTasks) task.Start();
        }

        public void Stop() => isWorking = false;

        private void CashDeskWork(CashDesk cashDesk, int sleepTime)
        {
            while(isWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleepTime);
                }
            }
        }
        
        private void CreateCarts(int customerCounts, int sleepTime)
        {
            while (isWorking)
            {
                Generator.GetNewCustomers(customerCounts);

                foreach (var customer in Generator.Customers)
                {
                    var cart = new Cart(customer);

                    foreach (var product in Generator.GetRandomProducts(10, 30))
                        cart.Add(product);

                    var cashDesk = CashDesks[rnd.Next(CashDesks.Count - 1)];
                    cashDesk.Enqueue(cart);
                }
                Thread.Sleep(sleepTime);
            }
        }
    }
}