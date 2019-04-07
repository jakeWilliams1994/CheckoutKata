using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class TestClasses
    {
        [TestMethod]
        public void WhenSkuIsA_CheckoutShouldReturn50()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            Assert.AreEqual(checkout.GetTotalPrice(), 50);
        }

        [TestMethod]
        public void WhenSkuIsB_CheckoutShouldReturn30()
        {
            var checkout = new Checkout();
            checkout.Scan("B");
            Assert.AreEqual(checkout.GetTotalPrice(), 30);
        }

        [TestMethod]
        public void WhenSkuIsC_CheckoutShouldReturn20()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            Assert.AreEqual(checkout.GetTotalPrice(), 20);
        }

        [TestMethod]
        public void WhenSkuIsD_CheckoutShouldReturn15()
        {
            var checkout = new Checkout();
            checkout.Scan("D");
            Assert.AreEqual(checkout.GetTotalPrice(), 15);
        }

        [TestMethod]
        public void WhenScanningMulitpleAs_CheckoutShouldCountSumOfAs()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(checkout.GetTotalPrice(), 100);
        }
    }
}
