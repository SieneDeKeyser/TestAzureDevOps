using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
   public class StockPrice
    {
        public decimal Price { get; set; }
        public StockCurrency CurrencyStock { get; private set; }
        public StockPrice(decimal price, StockCurrency currency)
        {
            Price = price;
            CurrencyStock = currency;
        }

        public override string ToString()
        {
            return CurrencyStock.Symbol + "\t" + Price;
        }

    }
}
