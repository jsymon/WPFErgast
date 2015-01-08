using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFErgast.APIs.Ergast.Models
{
    [Serializable]
    public class Race
    {
        [XmlAttribute]
        public int season { get; set; }

        [XmlAttribute]
        public int round { get; set; }

        [XmlAttribute]
        public string url { get; set; }

        [XmlElement]
        public string RaceName { get; set; }

        [XmlElement]
        public Circuit Circuit { get; set; }

        [XmlElement]
        public DateTime Date { get; set; }
    }
}
