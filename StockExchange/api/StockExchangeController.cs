using domain;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace api
{
    public class StockExchangeController
    {
        public StockService ServiceOfStock { get; private set; }
        public StockRepository StockRepository { get; private set; }
        public StockExchangeController()
        {
            StockRepository = new StockRepository();
            ServiceOfStock = new StockService(StockRepository);
        }
        public StockDTO GetStock(string stockId)
        {
            StockDTO tempStockDTO;

            tempStockDTO = new StockDTO(ServiceOfStock.GetStock(stockId));
            return tempStockDTO;

        }

    }
}
