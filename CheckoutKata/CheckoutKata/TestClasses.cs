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
            Assert.AreEqual(50, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenSkuIsB_CheckoutShouldReturn30()
        {
            var checkout = new Checkout();
            checkout.Scan("B");
            Assert.AreEqual(30 ,checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenSkuIsC_CheckoutShouldReturn20()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            Assert.AreEqual(20, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenSkuIsD_CheckoutShouldReturn15()
        {
            var checkout = new Checkout();
            checkout.Scan("D");
            Assert.AreEqual(15, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenScanningMulitpleAs_CheckoutShouldCountSumOfAs()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(100, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenScanningThreeAs_CheckoutShouldApplyOffer()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(130, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenScanningSixAs_CheckoutShouldApplyOffer()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(260, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void WhenScanningTwoBs_CheckoutShouldApplyOffer()
        {
            var checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");
            Assert.AreEqual(45, checkout.GetTotalPrice());
        }
    }
}
