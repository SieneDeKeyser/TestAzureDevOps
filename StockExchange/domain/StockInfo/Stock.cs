using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
   public class Stock
    {
        private readonly string id;
        private readonly string name;
        public StockPrice PriceOfStock { get; private set; }
        public Stock(string id, string name, StockPrice price)
        {
            this.id = id;
            this.name = name;
            PriceOfStock = price;
        }

        public override string ToString()
        {
            return name + "\tPrice: " + PriceOfStock.ToString();
        }

    }
}
