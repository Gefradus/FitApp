using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormEdytujPosilek : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly Walidacja walidacja = new Walidacja();
        public Form1 Form1 { get; set; }
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

        private void WczytajIloscProduktu()
        {
            textBox1.Text = _context.DajPosilek(PosilekID).Gramatura.ToString();
        }

        private void PodajLiczbeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Walidacja.PodajLiczbeTextBox(textBox1, e);
        }

        private void BtnEdytuj_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                if (!(int.Parse(textBox1.Text) == 0))
                {
                    List<Posilek> posilki = _context.Posilki();
                    foreach (var posilek in posilki)
                    {
                        if (posilek.PosilekId == PosilekID)
                        {
                            posilek.Gramatura = int.Parse(textBox1.Text);
                            break;
                        }
                    }

                    _context.ZapiszPosilki(posilki);
                    Hide();
                    Form1.OnLoad();
                }
                else
                {
                    walidacja.PokazBlad();
                }
            }
            else
            {
                walidacja.PokazBlad();
            }
        }

        private void PodajLiczbeTextBox_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa(textBox1, 4, false, 9999);
            new ObliczCele().WyswietlKcalIMakro(lblKcal, lblMakro, textBox1, _context.DajPosilek(PosilekID).ProduktId, _context);
        }

        private void FormEdytujPosilek_Load(object sender, EventArgs e)
        {
            WyswietlNazweProduktu();
            WczytajIloscProduktu();
        }
    }
}
