using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using codevist.iPara.DeveloperPortal.Core.Entity;
using codevist.iPara.DeveloperPortal.Core.Response;

namespace codevist.iPara.DeveloperPortal.Core.Request
{
    [XmlRoot("auth")]
    public class ThreeDPaymentCompleteRequest : BaseRequest
    {

        [XmlElement("threeD")]
        public string ThreeD { get; set; }

        [XmlElement("orderId")]
        public string OrderId { get; set; }

        [XmlElement("amount")]
        public string Amount { get; set; }


        [XmlElement("cardOwnerName")]
        public string CardOwnerName { get; set; }

        [XmlElement("cardNumber")]
        public string CardNumber { get; set; }

        [XmlElement("cardExpireMonth")]
        public string CardExpireMonth { get; set; }

        [XmlElement("cardExpireYear")]
        public string CardExpireYear { get; set; }

        [XmlElement("installment")]
        public string Installment { get; set; }

        [XmlElement("cardCvc")]
        public string Cvc { get; set; }


        [XmlElement("vendorId")]
        public string VendorId { get; set; }
        [XmlElement("userId")]
        public string UserId { get; set; }
        [XmlElement("cardId")]
        public string CardId { get; set; }

        [XmlElement("threeDSecureCode")]
        public string ThreeDSecureCode { get; set; }

        [XmlArray("products"), XmlArrayItem(typeof(Product), ElementName = "product", IsNullable = false)]
        public List<Product> Products { get; set; }

        [XmlElement("purchaser")]
        public Purchaser Purchaser { get; set; }
        public static ThreeDPaymentCompleteResponse Execute(ThreeDPaymentCompleteRequest request, Settings options)
        {
            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.OrderId + request.Amount + request.Mode + request.ThreeDSecureCode + options.transactionDate;
            return RestHttpCaller.Create().PostXML<ThreeDPaymentCompleteResponse>(options.BaseUrl + "rest/payment/auth", Helper.GetHttpHeaders(options, Helper.application_xml), request);
        }
    }




}

