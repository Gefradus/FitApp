using System.Xml.Serialization;

namespace FitApp
{
   public class Posilek
    {
        [XmlAttribute]
        public int PosilekId { get; set; }
        [XmlAttribute]
        public int WKtorym { get; set; }
        [XmlAttribute]
        public int DzienId { get; set; }
        [XmlAttribute]
        public int ProduktId { get; set; }
        public int Gramatura { get; set; }
    }
}
