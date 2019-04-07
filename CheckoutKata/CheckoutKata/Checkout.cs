using System;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        public void Scan(string sku)
        {
            switch (sku)
            {
                case "A":
                    _total += 50;
                    break;
                case "B":
                    _total += 30;
                    break;
                case "C":
                    _total += 20;
                    break;
                case "D":
                    _total += 15;
                    break;
            }
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}
