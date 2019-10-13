using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebCustomer
    {

        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string PostCode { get; set; }
        string City { get; set; }
        string Telephone { get; set; }
        string Password { get; set; }
        string ParachuteUserGuid { get; set; }
        DateTime MembershipExpiryDate { get; set; }

    }
}
