using CLI;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give StockId");
            string stockId = Console.ReadLine();
            MyCLI.Run(stockId);
        }
    }
}
