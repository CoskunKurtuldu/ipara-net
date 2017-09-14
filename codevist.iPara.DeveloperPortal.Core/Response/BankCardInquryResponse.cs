using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codevist.iPara.DeveloperPortal.Core.Entity;

namespace codevist.iPara.DeveloperPortal.Core.Response
{
    public class BankCardInquryResponse: BaseResponse
    {
        public List<BankCard> cards { get; set; }

    }
}
