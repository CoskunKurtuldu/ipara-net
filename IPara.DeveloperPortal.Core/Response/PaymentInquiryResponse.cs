using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IPara.DeveloperPortal.Core.Response
{
    [XmlRoot("inquiryResponse")]

    public class PaymentInquiryResponse:BaseResponse
    {
        [XmlElement("amount")]
        public string Amount { get; set; }
        [XmlElement("orderId")]
        public string OrderId { get; set; }
  



    }
}
