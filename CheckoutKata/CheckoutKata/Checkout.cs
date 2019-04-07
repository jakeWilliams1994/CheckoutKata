using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        private Dictionary<string, int> _scanned = new Dictionary<string, int> { { "A", 0 }, { "B", 0 } };
        public void Scan(string sku)
        {
            _total += _prices[sku];
            if (sku == "A")
            {
                _scanned[sku]++;
            }
            if (sku == "B")
            {
                _scanned[sku]++;
            }
        }

        public int GetTotalPrice()
        {
            if (_scanned["A"] % 3 == 0)
            {
                _total -= (20 * (_scanned["A"] / 3));
            }
            if (_scanned["B"] % 2 == 0)
            {
                _total -= (15 * (_scanned["B"] / 2));
            }
            return _total;
        }
    }
}
