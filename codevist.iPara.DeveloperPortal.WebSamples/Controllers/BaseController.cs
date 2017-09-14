using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codevist.iPara.DeveloperPortal.Core;
using codevist.iPara.DeveloperPortal.Core.Request;
using codevist.iPara.DeveloperPortal.Core.Response;
using System.Web;
using codevist.iPara.DeveloperPortal.Core.Entity;
using Newtonsoft.Json;

namespace codevist.iPara.DeveloperPortal.WebSamples.Controllers
{
    public class BaseController : Controller
    {
        public Settings settings = new Settings
        {
            PublicKey = "", //"Public Magaza Anahtarı - size mağaza başvurunuz sonucunda gönderilen publik key (açık anahtar) bilgisini kullanınız.",
            PrivateKey = "", //"Private Magaza Anahtarı  - size mağaza başvurunuz sonucunda gönderilen privaye key (gizli anahtar) bilgisini kullanınız.",
            BaseUrl = "https://apitest.ipara.com/", //iPara web servisleri API url'lerinin başlangıç bilgisidir. Restful web servis isteklerini takip eden kodlar halinde bulacaksınız.
                                                    // Örneğin "https://api.ipara.com/" + "/rest/payment/auth"  = "https://api.ipara.com/rest/payment/auth" 
            Version = "1.0", // Kullandığınız iPara API versiyonudur. 
            Mode = "T", // Test -> T, entegrasyon testlerinin sırasında "T" modunu, canlı sisteme entegre olarak ödeme almaya başlamak için ise Prod -> "P" modunu kullanınız.
            HashString = string.Empty // Kullanacağınız hash bilgisini, bağlanmak istediğiniz web servis bilgisine göre doldurulmalıdır. Bu bilgileri Entegrasyon rehberinin ilgili web servise ait bölümde bulabilirsiniz.
        };

    }
}