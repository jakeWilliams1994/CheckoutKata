using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private int _numberOfAs;
        private int _numberOfBs;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        public void Scan(string sku)
        {
            _total += _prices[sku];
            if (sku == "A")
            {
                _numberOfAs++;
            }
            if (sku == "B")
            {
                _numberOfBs++;
            }
        }

        public int GetTotalPrice()
        {
            if (_numberOfAs % 3 == 0)
            {
                _total -= (20 * (_numberOfAs / 3));
            }
            if (_numberOfBs % 2 == 0)
            {
                _total -= (15 * (_numberOfBs / 2));
            }
            return _total;
        }
    }
}
