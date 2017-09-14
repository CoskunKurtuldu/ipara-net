﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace codevist.iPara.DeveloperPortal.Core.Entity
{
    [XmlRoot("purchaser")]
    public class Purchaser
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("surname")]
        public string SurName { get; set; }

        [XmlElement("birthDate")]
        public string BirthDate { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("gsmNumber")]
        public string GsmPhone { get; set; }

        [XmlElement("tcCertificate")]
        public string IdentityNumber { get; set; }

        [XmlElement("clientIp")]
        public string ClientIp { get; set; }

        [XmlElement("invoiceAddress")]
        public PurchaserAddress InvoiceAddress { get; set; }

        [XmlElement("shippingAddress")]
        public PurchaserAddress ShippingAddress { get; set; }


    }
}