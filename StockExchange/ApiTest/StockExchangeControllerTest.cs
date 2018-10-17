using api;
using domain;
using System;
using System.Linq;
using Xunit;

namespace ApiTest
{
    public class StockExchangeControllerTest
    {
        [Fact]
        public void GivenStockExchangeController_WhenGetStock_ThenReturningStockDTOWithCorrectStock()
        {
            //Given
            StockExchangeController controller = new StockExchangeController();
            StockRepository stockrepository = new StockRepository();
            StockDTO stockDTOExpected = new StockDTO(stockrepository.StocksInRepositiory.Values.ToList()[0]);

            //when
            StockDTO stockDTOActual = controller.GetStock("AA");

            //Then
            Assert.Equal(stockDTOExpected.ThisStock, stockDTOActual.ThisStock);
        }
    }
}
