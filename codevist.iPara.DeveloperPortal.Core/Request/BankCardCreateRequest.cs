using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codevist.iPara.DeveloperPortal.Core.Entity;
using codevist.iPara.DeveloperPortal.Core.Response;

namespace codevist.iPara.DeveloperPortal.Core.Request
{
    public class BankCardCreateRequest : BaseRequest
    {
        public string userId { get; set; }
        public string cardOwnerName { get; set; }
        public string cardNumber { get; set; }

        public string cardAlias { get; set; }

        public string cardExpireMonth { get; set; }

        public string cardExpireYear { get; set; }

        public string clientIp { get; set; }


        public static BankCardCreateResponse Execute(BankCardCreateRequest request, Settings options)
        {
            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.userId + request.cardOwnerName + request.cardNumber +
                                 request.cardExpireMonth + request.cardExpireYear + request.clientIp +
                                 options.transactionDate;
            return RestHttpCaller.Create()
                .PostJson<BankCardCreateResponse>(options.BaseUrl + "/bankcard/create", Helper.GetHttpHeaders(options,Helper.application_json),
                    request);
        }
    }
}
