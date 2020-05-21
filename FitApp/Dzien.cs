using System;
using System.Xml.Serialization;

namespace FitApp
{
    public class Dzien
    {
        [XmlAttribute]
        public int DzienId { get; set; }
        [XmlAttribute]
        public int KlientId { get; set; }
        public DateTime Dzien1 { get; set; }
        public int CelKalorii { get; set; }
        public int CelBialko { get; set; }
        public int CelWegle { get; set; }
        public int CelTluszcze { get; set; }

    }
}
