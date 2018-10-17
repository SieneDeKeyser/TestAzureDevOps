using api;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI
{
   public class MyCLI
    {
       public static void Run(string stockId)
        {
            StockExchangeController controller = new StockExchangeController();
            Console.WriteLine(controller.GetStock(stockId));
            Console.ReadKey();
        }
    }
}
