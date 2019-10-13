using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OutstandingApiHelpers
{
    public interface IWebPayment
    {
       string CardNumber { get; set; }
       string CardName { get; set; }
       int ExpiryMonth { get; set; }
       int ExpiryYear { get; set; }
       string SecurityCode { get; set; }

    }
}
