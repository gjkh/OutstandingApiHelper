using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebSecurePayment
    {
        string CardNumber { get; set; }
        int ExpiryMonth { get; set; }
        int ExpiryYear { get; set; }
        string SecurityCode { get; set; }
        string CardName { get; set; }
        string CardPostCode { get; set; }
        decimal PaymentAmount { get; set; }

    }
}
