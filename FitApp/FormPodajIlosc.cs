﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormPodajIlosc : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly Walidacja walidacja = new Walidacja();
        public int ProduktID { get; set; }
        public int WKtorym { get; set; }
        public int DzienID { get; set; }

        public FormPodajIlosc()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => Powrot());
        }

        private void WyswietlNazweProduktu()
        {
            lblNazwa.Text = _context.DajProdukt(ProduktID).NazwaProduktu;
            lblNazwa.Location = new Point((Width - lblNazwa.Width)/2,10);
        }

        private void PodajLiczbeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!int.TryParse(e.KeyChar+"", out _) || (textBox1.Text.Length == 0 || textBox1.Text.Length > 3 ) && e.KeyChar == '0') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            int dodawanyProduktID = 0;

            foreach (var produkt in _context.Produkty())
            {
                if (produkt.ProduktId == ProduktID)
                {
                    dodawanyProduktID = ProduktID;
                }
            }

            if (int.TryParse(textBox1.Text, out _))
            {
                if (!(int.Parse(textBox1.Text) == 0))
                {
                    List<Posilek> posilki = _context.Posilki();
                    posilki.Add(new Posilek()
                    {
                        DzienId = DzienID,
                        Gramatura = int.Parse(textBox1.Text),
                        PosilekId = _context.AutoIncrementPosilki(_context.Posilki()),
                        ProduktId = dodawanyProduktID,
                        WKtorym = WKtorym
                    });

                    _context.ZapiszPosilki(posilki);

                    Form form1 = new Form1 { 
                        StartPosition = FormStartPosition.CenterScreen, 
                        DzienID = DzienID,
                        KlientID = _context.DajKlientaPoDniuID(DzienID)
                    };
                    
                    form1.Show();
                    Hide();
                }
                else
                {
                    PokazBlad();
                }
            }
            else
            {
                PokazBlad();
            }
        }

        public void PokazBlad()
        {
            MessageBox.Show("Należy podać ilość produktu w gramach!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Powrot()
        {
            FormDodawania form = new FormDodawania { 
                StartPosition = FormStartPosition.CenterScreen,
                DzienID = DzienID,
            };

            form.FormClosing += new FormClosingEventHandler((sender, e) => form.ZamknijForme());
            form.Show();
        }

        private void TxtBoxPodajIlosc_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa(textBox1, 4, false, 9999);
            WyswietlKcalIMakro();
        }


        private void WyswietlKcalIMakro()
        {
            int kalorie = 0, bialko = 0, wegle = 0, tluszcze = 0;
            try
            {
                Produkt produkt = _context.DajProdukt(ProduktID);
                int podanaIlosc = int.Parse(textBox1.Text);
                kalorie = (produkt.Kalorie * podanaIlosc) / 100;
                bialko = (int)(produkt.Bialko * podanaIlosc / 100);
                tluszcze = (int)(produkt.Tluszcze * podanaIlosc / 100);
                wegle = (int)(produkt.Weglowodany * podanaIlosc / 100);
            }
            catch {}

            lblKcal.Text = "Kcal: " + kalorie + " kcal";
            lblMakro.Text = "B: " + bialko + "g, W: " + wegle + "g, T: " + tluszcze + "g";
        }

        private void FormPodajIlosc_Load(object sender, EventArgs e)
        {
            WyswietlNazweProduktu();
        }
    }
}
