using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class TestClasses
    {
        [TestMethod]
        public void WhenSkuIsA_CheckoutShouldReturn50() => Assert.AreEqual(2, 50);
    }
}
