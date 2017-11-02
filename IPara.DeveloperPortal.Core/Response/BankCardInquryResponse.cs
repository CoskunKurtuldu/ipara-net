using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPara.DeveloperPortal.Core.Entity;

namespace IPara.DeveloperPortal.Core.Response
{
    public class BankCardInquryResponse: BaseResponse
    {
        public List<BankCard> cards { get; set; }

    }
}
