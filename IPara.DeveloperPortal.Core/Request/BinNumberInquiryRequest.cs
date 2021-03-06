﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPara.DeveloperPortal.Core.Entity;
using IPara.DeveloperPortal.Core.Response;

namespace IPara.DeveloperPortal.Core.Request
{
    public class BinNumberInquiryRequest :BaseRequest
    {
        public string binNumber { get; set; }
   

        public static BinNumberInquiryResponse Execute(BinNumberInquiryRequest request, Settings options)
        {
            options.transactionDate = Helper.GetTransactionDateString();
            options.HashString = options.PrivateKey + request.binNumber + options.transactionDate;
            return RestHttpCaller.Create().PostJson<BinNumberInquiryResponse>(options.BaseUrl + "rest/payment/bin/lookup", Helper.GetHttpHeaders( options, Helper.application_json), request);
        }
    }

}
