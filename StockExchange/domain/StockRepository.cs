using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
   public class StockRepository
    {
        private readonly Dictionary<string, Stock> stocksInDictionary;
        public Dictionary<string, Stock> StocksInRepositiory { get { return stocksInDictionary; } }
        public StockRepository()
        {
            stocksInDictionary = new Dictionary<string, Stock> { { "AA", new Stock("AA", "AA", new StockPrice(4, new StockCurrency(StockCurrency.Currency.EUR))) },{ "BB", new Stock("BB", "BB", new StockPrice(3, new StockCurrency(StockCurrency.Currency.USD))) }  };
        }

        public Stock GetStockInformation(string stockId)
        {
            return stocksInDictionary[stockId];
        }

    }
}
