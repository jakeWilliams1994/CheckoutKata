using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        private Dictionary<string, int> _scanned = new Dictionary<string, int>();
        private Dictionary<string, int> _offerThresholds = new Dictionary<string, int> { { "A", 3 }, { "B", 2 } };
        private Dictionary<string, int> _offers = new Dictionary<string, int> { { "A", 20 }, { "B", 15 } };
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
            foreach (var item in _scanned.Keys)
            {
                if (_offerThresholds.ContainsKey(item) && _scanned[item] % _offerThresholds[item] == 0)
                {
                    _total -= (_offers[item] * (_scanned[item] / _offerThresholds[item]));
                }
            }
            return _total;
        }
    }
}
