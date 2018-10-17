using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
  public class StockCurrency
    {
        public enum Currency { EUR, USD, GDP }
        public readonly Currency CurrencyOfStock;
        public string Label
        {
            get
            {
                string labelToReturn = "";
                switch (CurrencyOfStock)
                {
                    case Currency.EUR:
                        labelToReturn = "Euro";
                        break;
                    case Currency.USD:
                        labelToReturn = "US dollar";
                        break;
                    case Currency.GDP:
                        labelToReturn = "Pond";
                        break;
                }
                return labelToReturn;
            }
        }
        public string Symbol
        {
            get
            {
                string symbolToReturn = "";
                switch (CurrencyOfStock)
                {
                    case Currency.EUR:
                        symbolToReturn = "€";
                        break;
                    case Currency.USD:
                        symbolToReturn = "$";
                        break;
                    case Currency.GDP:
                        symbolToReturn = "£";
                        break;
                }
                return symbolToReturn;
            }
        }

        public StockCurrency(Currency currency)
        {
            CurrencyOfStock = currency;
        }
    }
}
