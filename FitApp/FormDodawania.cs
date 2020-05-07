using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FitApp
{
    public partial class FormDodawania : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private StyleOfFormDodawania _style = new StyleOfFormDodawania();

        public int WKtorym { get; set; }

        public FormDodawania()
        {
            InitializeComponent();
        }

        private void FormDodawania_Load(object sender, EventArgs e)
        {
            _style.CreatePlaceholderText(txtBoxSearch, panelGlowny, panelGorny,
                panelSearch, NazwaPosilku, btnHidden);

            NazwaPosilkuNapisz();
        }

        public void NazwaPosilkuNapisz()
        {
            if (WKtorym == 1) { NazwaPosilku.Text = "Śniadanie"; }
            if (WKtorym == 2) { NazwaPosilku.Text = "II śniadanie"; }
            if (WKtorym == 3) { NazwaPosilku.Text = "Obiad"; }
            if (WKtorym == 4) { NazwaPosilku.Text = "Deser"; }
            if (WKtorym == 5) { NazwaPosilku.Text = "Przekąska"; }
            if (WKtorym == 6) { NazwaPosilku.Text = "Kolacja"; }

            NazwaPosilku.Margin = new Padding((panelGorny.Width - NazwaPosilku.Width)/2,5,0,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Posilek> posilki = _context.Posilki();

            posilki.Add(new Posilek() { 
                PosilekId = _context.AutoIncrementPosilki(posilki), 
                Gramatura = 200, 
                WKtorym = 1, 
                ProduktId = 2, 
                DzienId = 1 
            });
            posilki.Add(new Posilek()
            {
                PosilekId = _context.AutoIncrementPosilki(posilki),
                Gramatura = 200,
                WKtorym = 1,
                ProduktId = 1,
                DzienId = 1
            });
            posilki.Add(new Posilek()
            {
                PosilekId = _context.AutoIncrementPosilki(posilki),
                Gramatura = 200,
                WKtorym = 2,
                ProduktId = 1,
                DzienId = 1
            });

            _context.ZapiszPosilki(posilki);
        }
    }
}
