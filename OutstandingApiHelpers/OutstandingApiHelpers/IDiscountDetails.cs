using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IDiscountDetails
    {

        int PerformancePriceBandId { get; set; }
        string PriceBandTitle { get; set; }
        int MinimumTickets { get; set; }
        int MaximumTickets { get; set; }
        bool IsTwoForOne { get; set; }

    }
}
