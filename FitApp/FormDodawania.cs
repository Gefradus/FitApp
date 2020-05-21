using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormDodawania : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly Style _style = new Style();
        public int DzienID { get; set; }
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
            NazwaDniaNapisz();
        }

        private void NazwaPosilkuNapisz()
        {
            if (WKtorym == 1) { NazwaPosilku.Text = "Śniadanie"; }
            if (WKtorym == 2) { NazwaPosilku.Text = "II śniadanie"; }
            if (WKtorym == 3) { NazwaPosilku.Text = "Obiad"; }
            if (WKtorym == 4) { NazwaPosilku.Text = "Deser"; }
            if (WKtorym == 5) { NazwaPosilku.Text = "Przekąska"; }
            if (WKtorym == 6) { NazwaPosilku.Text = "Kolacja"; }

            NazwaPosilku.Location = new Point((panelGorny.Width - NazwaPosilku.Width) / 2, 5);
        }

        private void NazwaDniaNapisz()
        {
            DateTime dzien = _context.DajDzien(DzienID).Dzien1;
            string miesiac = Form1.DajMiesiac(dzien.Month);


            if (dzien == DateTime.Now.Date) {
                lblDzien.Text = "Dzisiaj";
            }
            else if (dzien.Date == DateTime.Now.Date.AddDays(-1)) {
                lblDzien.Text = "Wczoraj";
            }
            else if (dzien.Date == DateTime.Now.Date.AddDays(1)) {
                lblDzien.Text = "Jutro";
            }
            else
            {
                lblDzien.Text = dzien.Day + " " + miesiac;
            }

            lblDzien.Location = new Point((panelGorny.Width - lblDzien.Width) / 2, 40);
        }


        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string wyszukiwanaFraza = txtBoxSearch.Text;

            List<Produkt> wyszukaneProdukty = new List<Produkt>();
            foreach (var produkt in _context.Produkty()){
                if (produkt.NazwaProduktu.ToLower().Contains(wyszukiwanaFraza.ToLower()) && !string.IsNullOrWhiteSpace(wyszukiwanaFraza))
                {
                    wyszukaneProdukty.Add(produkt);
                }
            }

            panelGlowny.Controls.Clear();
            foreach (var item in wyszukaneProdukty)
            {
                UtworzPanelProduktu(item.ProduktId);
            }
        }

        private void UtworzPanelProduktu(int produktID)
        {
            Produkt produkt = _context.DajProdukt(produktID);
            Panel panel = new Panel()
            {
                Size = new Size(369, 50),
                BackColor = Color.GhostWhite,
                Margin = new Padding(40, 2, 0, 0),
                Visible = true,
                BorderStyle = BorderStyle.FixedSingle,
            };
            Label labelNazwa = new Label
            {
                Text = produkt.NazwaProduktu,
                Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Bold, GraphicsUnit.Point),
                Location = new Point(5, 3),
                AutoSize = true
            };
            Label labelParametry = new Label
            {
                Text = produkt.Kalorie + " kcal,  " + produkt.Bialko + "g. B,  "
                + produkt.Weglowodany + "g. W,  " + produkt.Tluszcze + "g. T   / 100g",

                Font = new Font("Microsoft Sans Serif", 9.5F),
                Location = new Point(5, 27),
                AutoSize = true
            };

            Button button = new Button()
            {
                Text = "Dodaj",
                Size = new Size(75, 30),
                Location = new Point(275, 10),
                BackColor = Color.Green,
                ForeColor = Color.White

            };

            button.Click += new EventHandler((sender, e) => BtnAddClick(produktID));
            panel.Controls.Add(labelNazwa);
            panel.Controls.Add(labelParametry);
            panel.Controls.Add(button);
            panelGlowny.Controls.Add(panel);
        }

        private void BtnAddClick(int produktID)
        {
            FormPodajIlosc formPodaj = new FormPodajIlosc
            {
                ProduktID = produktID,
                WKtorym = WKtorym,
                DzienID = DzienID
            };
            formPodaj.Show();
            Hide();
        }

        public void ZamknijForme()
        {
            Form form1 = new Form1 { 
                StartPosition = FormStartPosition.CenterScreen, 
                KlientID = _context.DajKlientaPoDniuID(DzienID),
                DzienID = DzienID
            };
            form1.Show();
            Hide();
        }

        private void PaintBorder(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Border.Width, 1);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Hide();
            new FormNowyProdukt(DzienID, WKtorym).Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ZamknijForme();
        }

        private void panelGlowny_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
