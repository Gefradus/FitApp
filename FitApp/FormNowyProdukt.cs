using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormNowyProdukt : Form
    {
        private readonly Style style = new Style();
        private readonly ModelXML _context = new ModelXML();
        private readonly Walidacja walidacja = new Walidacja();
        private bool CzyBialkoZle { get; set; }
        private bool CzyTluszczeZle { get; set; }
        private bool CzyWegleZle { get; set; }
        private bool CzyKcalZle { get; set; }
        private bool CzyNazwaZle { get; set; }
        public int DzienID { get; set; }
        public int WKtorym { get; set; }

        public FormNowyProdukt(int dzienID, int wKtorym)
        {
            DzienID = dzienID;
            WKtorym = wKtorym;
            InitializeComponent();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Powrot();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            JesliNiePodano();
            DodajProdukt();
        }

        private void JesliNiePodano()
        {
            if (string.IsNullOrWhiteSpace(txtKcal.Text)) { lblKcal.ForeColor = Color.Red; CzyKcalZle = true; }
            else { lblKcal.ForeColor = Color.Black; CzyKcalZle = false;  }

            if (string.IsNullOrWhiteSpace(txtBialko.Text)) { lblBialko.ForeColor = Color.Red; CzyBialkoZle = true; }
            else { lblBialko.ForeColor = Color.Black; CzyBialkoZle = false; }

            if (string.IsNullOrWhiteSpace(txtWegl.Text)) { lblWegle.ForeColor = Color.Red; CzyWegleZle = true; }
            else { lblWegle.ForeColor = Color.Black; CzyWegleZle = false; }

            if (string.IsNullOrWhiteSpace(txtTluszcz.Text)) { lblTluszcze.ForeColor = Color.Red; CzyTluszczeZle = true; }
            else { lblTluszcze.ForeColor = Color.Black; CzyTluszczeZle = false; }

            if (string.IsNullOrWhiteSpace(txtNazwa.Text)) { lblNazwa.ForeColor = Color.Red; CzyNazwaZle = true; }
            else { lblNazwa.ForeColor = Color.Black; CzyNazwaZle = false; }

            Refresh();
        }

        private void DodajProdukt()
        {
            try
            {
                string nazwaBezBialychZnakow = Walidacja.UsunBialeZnakiZeStringa(txtNazwa.Text);
                if (nazwaBezBialychZnakow.Length >= 3)
                {
                    List<Produkt> produkty = _context.Produkty();
                    produkty.Add(new Produkt()
                    {
                        ProduktId = _context.AutoIncrementProdukty(produkty),
                        NazwaProduktu = nazwaBezBialychZnakow,
                        Kalorie = int.Parse(txtKcal.Text),
                        Bialko = double.Parse(txtBialko.Text),
                        Tluszcze = double.Parse(txtTluszcz.Text),
                        Weglowodany = double.Parse(txtWegl.Text)
                    });

                    _context.ZapiszProdukty(produkty);
                    Powrot();
                }
                else
                {
                    if (!CzyNiePodano())
                    {
                        MessageBox.Show("Nazwa produktu musi liczyć co najmniej 3 znaki!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNazwa.Text = nazwaBezBialychZnakow;
                    }
                }
            }
            catch
            {
                if(!CzyNiePodano()){
                    MessageBox.Show("Błędnie podane dane!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Powrot()
        {
            Hide();
            FormDodawania form = new FormDodawania()
            {
                DzienID = DzienID,
                WKtorym = WKtorym
            };

            form.FormClosing += new FormClosingEventHandler((sender, e) => form.ZamknijForme());
            form.Show();
        }


        private bool CzyNiePodano()
        {
            return string.IsNullOrWhiteSpace(txtKcal.Text) || string.IsNullOrWhiteSpace(txtBialko.Text)  ||
                   string.IsNullOrWhiteSpace(txtWegl.Text) || string.IsNullOrWhiteSpace(txtTluszcz.Text) ||
                   string.IsNullOrWhiteSpace(txtNazwa.Text);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            style.RysujLubZresetuj(CzyNazwaZle, txtNazwa, e);
            style.RysujLubZresetuj(CzyBialkoZle, txtBialko, e);
            style.RysujLubZresetuj(CzyWegleZle, txtWegl, e);
            style.RysujLubZresetuj(CzyTluszczeZle, txtTluszcz, e);
            style.RysujLubZresetuj(CzyKcalZle, txtKcal, e);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa((TextBox)sender, 3, true, 100);
        }

        private void TextBoxKcal_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa((TextBox)sender, 3, false, 900);
        }
    }
}
