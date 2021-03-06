﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPara.DeveloperPortal.Core.Entity;
using IPara.DeveloperPortal.Core.Response;

namespace IPara.DeveloperPortal.Core.Request
{
    public class BankCardDeleteRequest : BaseRequest
    {
        public string userId { get; set; }
        public string cardId { get; set; }
        public string clientIp { get; set; }


        public static BankCardDeleteResponse Execute(BankCardDeleteRequest request, Settings options)
        {
            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.userId + request.cardId + request.clientIp + options.transactionDate;
            return RestHttpCaller.Create()
                .PostJson<BankCardDeleteResponse>(options.BaseUrl + "/bankcard/delete", Helper.GetHttpHeaders(options,Helper.application_json),
                    request);
        }
    }
}
