using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        }
    }
}