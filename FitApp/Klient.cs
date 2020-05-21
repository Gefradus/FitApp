using System;
using System.Xml.Serialization;

namespace FitApp
{
    public class Klient
    {
        [XmlAttribute]
        public int KlientID { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public bool CzyPamietac { get; set; }
        public int CelKalorii { get; set; }
        public int CelBialko { get; set; }
        public int CelWegle { get; set; }
        public int CelTluszcze { get; set; }
        public short CelZmianWagi { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public decimal TempoZmian { get; set; }
        public bool Plec { get; set; }
        public int Wzrost { get; set; }
        public double Waga { get; set; }
    }
}
