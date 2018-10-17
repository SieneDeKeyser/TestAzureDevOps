using domain;
using Service;
using System;
using Xunit;

namespace ServiceTest
{
    public class StockServiceTest
    {
        [Fact]
        public void GivenStockService_WhenGetPriceInEuroForStock_ThenReturnRandomNumberBetween10and100()
        {
            //Given
            StockRepository stockRepository = new StockRepository();
            StockService stockService = new StockService(stockRepository);

            //When
            decimal actualPrice = stockService.GetPriceInEuroForStock("AA");

            //Then
            Assert.InRange<decimal>(actualPrice, 10, 100);
         }
    }
}
