using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFErgast.APIs.Ergast.Models
{
    [Serializable]
    public class Circuit
    {
        [XmlAttribute]
        public string circuitId { get; set; }

        [XmlAttribute]
        public string url { get; set; }

        [XmlElement]
        public string CircuitName { get; set; }

        [XmlElement]
        public Location Location { get; set; }
    }
}
