using System;
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


        private void Form_Closing(object sender1, FormClosingEventArgs e1)
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

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            JesliNiePodano();
        }

        private void JesliNiePodano()
        {
            if (string.IsNullOrEmpty(txtKcal.Text) || string.IsNullOrWhiteSpace(txtKcal.Text))
                 { lblKcal.ForeColor = Color.Red; CzyKcalZle = true; }
            else { lblKcal.ForeColor = Color.Black; CzyKcalZle = false;  }

            if (string.IsNullOrEmpty(txtBialko.Text) || string.IsNullOrWhiteSpace(txtBialko.Text))
                 { lblBialko.ForeColor = Color.Red; CzyBialkoZle = true; }
            else { lblBialko.ForeColor = Color.Black; CzyBialkoZle = false; }

            if (string.IsNullOrEmpty(txtWegl.Text) || string.IsNullOrWhiteSpace(txtWegl.Text))
                 { lblWegle.ForeColor = Color.Red; CzyWegleZle = true; }
            else { lblWegle.ForeColor = Color.Black; CzyWegleZle = false; }

            if (string.IsNullOrEmpty(txtTluszcz.Text) || string.IsNullOrWhiteSpace(txtTluszcz.Text))
                 { lblTluszcze.ForeColor = Color.Red; CzyTluszczeZle = true; }
            else { lblTluszcze.ForeColor = Color.Black; CzyTluszczeZle = false; }

            if (string.IsNullOrEmpty(txtNazwa.Text) || string.IsNullOrWhiteSpace(txtNazwa.Text))
                 { lblNazwa.ForeColor = Color.Red; CzyNazwaZle = true; }
            else { lblNazwa.ForeColor = Color.Black; CzyNazwaZle = false; }

            Refresh();
        }

        private void FormNowyProdukt_Load(object sender, EventArgs e)
        {

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
