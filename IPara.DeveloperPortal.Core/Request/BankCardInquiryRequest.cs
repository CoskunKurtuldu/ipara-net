﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPara.DeveloperPortal.Core.Entity;
using IPara.DeveloperPortal.Core.Response;

namespace IPara.DeveloperPortal.Core.Request
{
    public class BankCardInquiryRequest: BaseRequest
    {
        public string userId { get; set; } 
        public string clientIp { get; set; }
        public string cardId { get; set; }


        public static BankCardInquryResponse Execute(BankCardInquiryRequest request, Settings options)
        {
            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.userId + request.cardId + request.clientIp + options.transactionDate;
            return RestHttpCaller.Create().PostJson<BankCardInquryResponse>(options.BaseUrl + "/bankcard/inquiry", Helper.GetHttpHeaders(options, Helper.application_json), request);
        }


    }
}
