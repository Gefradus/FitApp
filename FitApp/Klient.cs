using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp
{
    public class Klient
    {
        public int KlientID { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public int CelKalorii { get; set; }
        public int CelBialko { get; set; }
        public int CelWegle { get; set; }
        public int CelTluszcze { get; set; }
        public bool Plec { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }
        

/*      public bool Sniadanie { get; set; }
        public bool IISniadanie { get; set; }
        public bool Obiad { get; set; }
        public bool Deser { get; set; }
        public bool Przekaska { get; set; }
        public bool Kolacja { get; set; }*/
    }
}
