using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class OfferCalculator
    {
        private Dictionary<string, int> _offerThresholds = new Dictionary<string, int> { { "A", 3 }, { "B", 2 } };
        private Dictionary<string, int> _offers = new Dictionary<string, int> { { "A", 20 }, { "B", 15 } };
        public int CalculateOffer(Dictionary<string, int> scannedItems)
        {
            var totalDiscount = 0;
            foreach (var item in scannedItems.Keys)
            {
                if (_offerThresholds.ContainsKey(item) && scannedItems[item] % _offerThresholds[item] == 0)
                {
                    totalDiscount += (_offers[item] * (scannedItems[item] / _offerThresholds[item]));
                }
            }
            return totalDiscount;
        }
    }
}
