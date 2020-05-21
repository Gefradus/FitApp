using System.Xml.Serialization;

namespace FitApp
{
    public class Produkt
    {
        [XmlAttribute]
        public int ProduktId { get; set; }
        public string NazwaProduktu { get; set; }
        public int Kalorie { get; set; }
        public double Bialko { get; set; }
        public double Tluszcze { get; set; }
        public double Weglowodany { get; set; }

    }
}
