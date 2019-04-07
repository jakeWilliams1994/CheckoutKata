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
    }
}
