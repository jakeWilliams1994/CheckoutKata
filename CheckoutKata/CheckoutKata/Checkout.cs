using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        public void Scan(string sku)
        {
            _total += _prices[sku];
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}
