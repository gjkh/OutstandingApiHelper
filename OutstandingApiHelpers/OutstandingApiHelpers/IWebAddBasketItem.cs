using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebAddBasketItem
    {
        WebBasketItemType BasketItemType { get; set; }
        int PerformancePriceBandId { get; set; }
        int TotalTickets { get; set; }
    }
}
