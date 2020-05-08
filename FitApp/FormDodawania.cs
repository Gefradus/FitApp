using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormDodawania : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly StyleOfFormDodawania _style = new StyleOfFormDodawania();

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

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string wyszukiwanaFraza = txtBoxSearch.Text;

            List<Produkt> wyszukaneProdukty = new List<Produkt>();
            foreach (var produkt in _context.Produkty()){
                if (produkt.NazwaProduktu.ToLower().StartsWith(wyszukiwanaFraza.ToLower()) && !string.IsNullOrWhiteSpace(wyszukiwanaFraza))
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
            Panel panel = new Panel()
            {
                Size = new Size(369, 50),
                BackColor = Color.GhostWhite,
                Margin = new Padding(40, 0, 0, 0),
                Visible = true,
                BorderStyle = BorderStyle.FixedSingle,
            };
            Label label = new Label
            {
                Text = _context.DajProdukt(produktID).NazwaProduktu,
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                Location = new Point(5, 5)
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
            panel.Controls.Add(label);
            panel.Controls.Add(button);
            panelGlowny.Controls.Add(panel);
        }

        private void BtnAddClick(int produktID)
        {
            FormPodajIlosc formPodaj = new FormPodajIlosc
            {
                ProduktID = produktID,
                WKtorym = WKtorym
            };

            formPodaj.Show();
            Hide();
            
        }

        public void ZamknijForme()
        {
            Form form1 = new Form1 { StartPosition = FormStartPosition.CenterScreen };
            form1.Show();
            Hide();
        }
    }
}
