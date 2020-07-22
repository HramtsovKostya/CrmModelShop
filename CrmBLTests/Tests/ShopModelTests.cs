using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class ShopModelTests
    {
        [TestMethod()]
        public void ShopModelTest()
        {
            var model = new ShopModel();

            model.Start();
            Thread.Sleep(10000);
            model.Stop();
        }
    }
}