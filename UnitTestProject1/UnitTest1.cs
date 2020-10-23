using Demo.Design.工厂模式;
using Demo.Design.工厂模式.store;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            StoreFactory storeFactory = new StoreFactory();

            //优惠券
            ICommodity commodity1 = storeFactory.GetCommodityService(1);
            commodity1.sendCommodity("10001", "EGM123112", "2132131", null);

            Assert.IsNotNull(commodity1);
        }
        [TestMethod]
        public void TestMethodFailing()
        {

        }
    }
}
