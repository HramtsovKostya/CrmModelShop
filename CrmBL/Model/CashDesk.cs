using CrmBL.DataBase;
using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class CashDesk
    {
        private readonly CrmContext dbContext;

        public int Number { get; }
        public Seller Seller { get; }
        public Queue<Cart> Queue { get; }
        public int MaxQueueLength { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public event EventHandler<Check> CheckClosed;

        public CashDesk(int number, Seller seller, CrmContext dbContext)
        {
            this.dbContext = dbContext ?? new CrmContext();

            Queue = new Queue<Cart>();            
            Number = number;
            Seller = seller;            
            IsModel = true;
            MaxQueueLength = 10;
        }

        public void Enqueue(Cart cart)
        {
            if (Queue.Count < MaxQueueLength) Queue.Enqueue(cart);            
            else ExitCustomer++;
        }

        public decimal Dequeue()
        {
            if (Queue.Count == 0) return 0;

            decimal fullPrice = 0;
            var cart = Queue.Dequeue();

            if (cart != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = cart.Customer.CustomerId,
                    Customer = cart.Customer,
                    Created = DateTime.Now
                };

                if (!IsModel)
                {
                    dbContext.Checks.Add(check);
                    dbContext.SaveChanges();
                }
                else check.CheckId = 0;               

                var sells = new List<Sell>();

                foreach (var product in cart)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        { 
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product                        
                        };
                    
                        sells.Add(sell);
                        if (!IsModel) dbContext.Sells.Add(sell);

                        product.Count--;
                        fullPrice += product.Price;
                    }
                }
                check.Price = fullPrice;
                if (!IsModel) dbContext.SaveChanges();

                CheckClosed?.Invoke(this, check);
            }
            return fullPrice;
        }

        public override string ToString() => $"Касса №{Number}";
    }
}