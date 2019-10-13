using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebGiftVoucher
    {
       string RecipientName { get; set; }
       string Address1 { get; set; }
       string Address2 { get; set; }
       string City { get; set; }
       string PostCode { get; set; }
       string Message { get; set; }
       string ContactTelephoneNumber { get; set; }
       bool IsRecipientPurchaser { get; set; }
    }
}
