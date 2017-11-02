using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using IPara.DeveloperPortal.Core.Response;

namespace IPara.DeveloperPortal.Core.Request
{
    [XmlRoot("inquiry")]
    public class PaymentInquiryRequest:BaseRequest
    {
        [XmlElement("orderId")]
        public string orderId { get; set; }

        public static PaymentInquiryResponse Execute(PaymentInquiryRequest request, Settings options)
        {

            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.orderId +options.Mode + options.transactionDate;
            return RestHttpCaller.Create().PostXML<PaymentInquiryResponse>(options.BaseUrl + "rest/payment/inquiry", Helper.GetHttpHeaders(options, Helper.application_xml), request);
        }
    }
}
