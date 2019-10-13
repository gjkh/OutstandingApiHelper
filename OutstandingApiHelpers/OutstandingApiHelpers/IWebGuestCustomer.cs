using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebGuestCustomer
    {
       string FirstName { get; set; }
       string LastName { get; set; }
       string EmailAddress { get; set; }
       string Telephone { get; set; }
       string ParachuteUserGuid { get; set; }
    }
}
