using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private int _total;
        private Dictionary<string, int> _prices = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
        private Dictionary<string, int> _scanned = new Dictionary<string, int>();
        private OfferCalculator _offerCalulator;

        public Checkout(OfferCalculator offerCalulator)
        {
            _offerCalulator = offerCalulator;
        }
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
            return _total -= _offerCalulator.CalculateOffer(_scanned);
        }
    }
}
