using domain;
using System;
using System.Linq;
using Xunit;

namespace DomainTest
{
    public class StockRepositoryTest
    {
        
             [Fact]
        public void GivenStockRepositoryWithThatStock_WhenGetStockInformation_ThenReturnThatStock()
        {
            //Given
            StockRepository stockRepository = new StockRepository();

            //When
            Stock actualStock =  stockRepository.GetStockInformation("AA");
            Stock expectedStock = stockRepository.StocksInRepositiory.Values.ToList()[0];

            //then
            Assert.Equal(expectedStock, actualStock);
        }

        [Fact]
        public void GivenStockRepositoryWithoutThatStock_WhenGetStockInformation_ThenThrowException()
        {
            //Given
            StockRepository stockRepository = new StockRepository();

            //When
            Action act = () => stockRepository.GetStockInformation("CC");

            //then
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(act);
        }
    
    }
}
