using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            // Arrange
            var customer1 = new Customer()
            {
                CustomerId = 1,
                Name = "TestUser1"
            };

            var customer2 = new Customer()
            {
                CustomerId = 2,
                Name = "TestUser2"
            };

            var seller = new Seller()
            {
                SellerId = 1,
                Name = "SellerName"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };

            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };

            var cart1 = new Cart(customer1)
            {
                product1,
                product1,
                product2
            };

            var cart2 = new Cart(customer2)
            {
                product1,
                product2,
                product2
            };

            var cashDesk = new CashDesk(1, seller)
            {
                MaxQueueLength = 10
            };

            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);

            var cart1ExpectedResult = 400;
            var cart2ExpectedResult = 500;

            // Act
            var cart1ActualResult = cashDesk.Dequeue();
            var cart2ActualResult = cashDesk.Dequeue();

            // Assert
            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(17, product2.Count);
        }
    }
}