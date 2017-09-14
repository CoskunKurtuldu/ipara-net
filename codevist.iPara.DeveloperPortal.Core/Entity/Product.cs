using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace codevist.iPara.DeveloperPortal.Core.Entity
{
    public class Product
    {   
        [XmlElement("productCode")]
        public string Code { get; set; }

        [XmlElement("productName")]
        public string Title { get; set; }

        [XmlElement("quantity")]
        public int Quantity { get; set; }

        [XmlElement("price")]
        public string Price { get; set; }
    }
}