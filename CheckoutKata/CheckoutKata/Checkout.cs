using System;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        public void Scan(string sku)
        {
            if (sku == "A")
                _total += 50;
            else
                _total += 30;
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}
