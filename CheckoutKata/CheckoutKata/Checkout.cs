using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        private Dictionary<string, int> _scanned = new Dictionary<string, int>();
        public void Scan(string sku)
        {
            _total += _prices[sku];
            if (_scanned.ContainsKey(sku)) {
                _scanned[sku]++;
            }
            else
            {
                _scanned.Add(sku, 1);
            }
        }

        public int GetTotalPrice()
        {
            if (_scanned.ContainsKey("A") &&_scanned["A"] % 3 == 0)
            {
                _total -= (20 * (_scanned["A"] / 3));
            }
            if (_scanned.ContainsKey("B") && _scanned["B"] % 2 == 0)
            {
                _total -= (15 * (_scanned["B"] / 2));
            }
            return _total;
        }
    }
}
