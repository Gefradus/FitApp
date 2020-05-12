using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormEdytujPosilek : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly Walidacja walidacja = new Walidacja();
        public int PosilekID { get; set; }
        public int WKtorym { get; set; }
        public int DzienID { get; set; }

        public FormEdytujPosilek()
        {
            InitializeComponent();
        }

        private void WyswietlNazweProduktu()
        {
            lblNazwa.Text = _context.DajProdukt(_context.DajPosilek(PosilekID).ProduktId).NazwaProduktu;
            lblNazwa.Location = new Point((Width - lblNazwa.Width) / 2, 10);
        }
    }
}
