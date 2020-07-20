using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class CashDesk
    {
        private readonly CrmContext dbContext;

        public int Number { get; set; }

        public Seller Seller { get; set; }

        public Queue<Cart> Queue { get; set; }

        public int MaxQueueLength { get; set; }

        public int ExitCustomer { get; set; }

        public bool IsModel { get; set; }

        public CashDesk(int number, Seller seller)
        {
            dbContext = new CrmContext();
            Queue = new Queue<Cart>();
            Number = number;
            Seller = seller;            
            IsModel = true;
        }

        public void Enqueue(Cart cart)
        {
            if (Queue.Count <= MaxQueueLength)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;
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
                else
                {
                    check.CheckId = 0;
                }

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

                        if (!IsModel)
                        {
                            dbContext.Sells.Add(sell);
                        }

                        product.Count--;
                        sum += product.Price;
                    }
                }

                if (!IsModel)
                {
                    dbContext.SaveChanges();
                }                
            }
            return sum;
        }
    }
}