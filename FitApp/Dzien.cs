using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp
{
    public class Dzien
    {
        public int DzienId { get; set; }
        public int KlientId { get; set; }
        public DateTime Dzien1 { get; set; }
        public int CelKalorii { get; set; }
        public int CelBialko { get; set; }
        public int CelWegle { get; set; }
        public int CelTluszcze { get; set; }

        /*      public bool Sniadanie { get; set; }
        public bool IISniadanie { get; set; }
        public bool Obiad { get; set; }
        public bool Deser { get; set; }
        public bool Przekaska { get; set; }
        public bool Kolacja { get; set; }*/
    }
}
