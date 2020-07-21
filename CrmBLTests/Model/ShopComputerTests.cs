using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class ShopComputerTests
    {
        [TestMethod()]
        public void ShopComputerTest()
        {
            var model = new ShopComputer();
            model.Start();
            Thread.Sleep(10000);
        }
    }
}