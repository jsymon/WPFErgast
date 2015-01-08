using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFErgast.APIs.Ergast.Models
{
    public class Location
    {
        [XmlElement]
        public string Locality { get; set; }

        [XmlElement]
        public string Country { get; set; }
    }
}
