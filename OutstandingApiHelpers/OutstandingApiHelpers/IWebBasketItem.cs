using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{

    public interface IWebBasketItem
    {
        string BasketItemId { get; set; }
        WebBasketItemType BasketItemType { get; set; }
        string PerformanceTitle { get; set; }
        DateTime PerformanceStarts { get; set; }
        string PriceBandTitle { get; set; }
        decimal PriceBandValue { get; set; }
        int TotalTickets { get; set; }
        decimal TotalValue { get; set; }
        bool TicketAmountLocked { get; set; }
        bool IsTwoForOne { get; set; }
        bool IsDiscount { get; set; }

    }

}
