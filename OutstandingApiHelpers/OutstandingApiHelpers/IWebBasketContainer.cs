using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebBasketContainer
    {

       string ParachuteUserGuid { get; set; }
       List<IWebBasketItem> BasketItems { get; set; }
       bool PostageAvailable { get; set; }
       bool PostageSelected { get; set; }
       int TotalPerformances { get; set; }
       int TotalTickets { get; set; }
       decimal TotalTicketValue { get; set; }
       decimal BookingFeeTotal { get; set; }
       decimal OtherItemsSubTotal { get; set; }
       decimal PostageValue { get; set; }
       decimal BasketTotalValue { get; set; }
       int BookingId { get; set; }

    }
}
