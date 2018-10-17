using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    public interface IExternalStockInformationService
    {
        decimal GetPriceInEuroForStock(string stockId);
    }
}
