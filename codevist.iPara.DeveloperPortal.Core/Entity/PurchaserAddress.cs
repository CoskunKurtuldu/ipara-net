using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace codevist.iPara.DeveloperPortal.Core.Entity
{
    public class PurchaserAddress
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("surname")]
        public string SurName { get; set; }

        [XmlElement("address")]
        public string Address { get; set; }

        [XmlElement("zipcode")]
        public string ZipCode { get; set; }

        [XmlElement("city")]        
        public string CityCode { get; set; }
                
        [XmlElement("tcCertificate")]
        public string IdentityNumber { get; set; }

        [XmlElement("country")]
        public string CountryCode { get; set; }
        
        [XmlElement("taxNumber")]
        public string TaxNumber { get; set; }
               
        [XmlElement("taxOffice")]
        public string TaxOffice { get; set; }
        
        [XmlElement("companyName")]
        public string CompanyName { get; set; }

        [XmlElement("phoneNumber")]
        public string PhoneNumber { get; set; }
                
    }
}