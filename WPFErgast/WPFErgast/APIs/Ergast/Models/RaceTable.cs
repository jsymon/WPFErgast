using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFErgast.APIs.Ergast.Models
{
    [Serializable]
    public class RaceTable
    {
        [XmlElement]
        public Race[] Race { get; set; }

        [XmlAttribute]
        public int season { get; set; }
    }
}
