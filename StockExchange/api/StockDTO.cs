using System;
using System.Collections.Generic;
using System.Text;
using domain;

namespace api
{
   public class StockDTO
    {
        public readonly Stock ThisStock;
        public string Name { get;}
        public StockPrice PriceOfThisStock { get; private set; }
        public StockDTO(Stock thisStock)
        {
            Name = thisStock.ToString();
            PriceOfThisStock = thisStock.PriceOfStock;
        }
        public override string ToString()
        {
            return Name; 
        }
    }
}
