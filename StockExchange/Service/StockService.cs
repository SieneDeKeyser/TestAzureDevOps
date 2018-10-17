using domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public class StockService: IExternalStockInformationService
    {
        public StockRepository RepositoryOfStocks { get;}
        public StockService(StockRepository stockRepository)
        {
            RepositoryOfStocks = stockRepository;
        }
        public Stock GetStock(string stockId)
        {
            try
            {
            return RepositoryOfStocks.GetStockInformation(stockId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public decimal GetPriceInEuroForStock(string stockId)
        {
            Random rnd = new Random();
            return rnd.Next(10, 101);
        }
    }
}
