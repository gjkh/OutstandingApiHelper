using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingApiHelpers
{
    public interface IWebLogin
    {
       string EmailAddress { get; set; }
       string Password { get; set; }
       string ParachuteUserGuid { get; set; }
    }
}
