using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormUstawien : Form
    {
        private readonly ModelXML _context;
        public int KlientID { get; set; }
        public int DzienID { get; set; }
        public bool CzyPierwszeUruchomienie { get; set; }

        public FormUstawien()
        {
            _context = new ModelXML();
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(Form_Closing);
        }


        private void Powrot()
        {
            Hide();

            if (CzyPierwszeUruchomienie)
            {
                new FormLogowania().Show();
            }
            else
            {
                Form form1 = new Form1()
                {
                    KlientID = KlientID,
                    DzienID = DzienID
                };

                form1.Show();
            }
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Powrot();
        }

        private void WczytajUstawienia()
        {
            if (!CzyPierwszeUruchomienie)
            {
                Klient klient = _context.DajKlienta(KlientID);

                try { txtTempo.Value = klient.TempoZmian; }
                catch { txtTempo.Value = 0.5M; }

                txtWaga.Text = klient.Waga + "";
                txtWzrost.Text = klient.Wzrost + "";
                dateTimePicker1.Value = klient.DataUrodzenia;
                rbtnMezczyzna.Checked = klient.Plec;

                if (klient.CelZmianWagi == 0) { rbtnSchudnie.Checked = true; }
                else if(klient.CelZmianWagi == 1) { rbtnUtrzymanie.Checked = true; }
                else { rbtnPrzytyj.Checked = true; }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtWaga.Text, out _) && !int.TryParse(txtWzrost.Text, out _))
            {
                MessageBox.Show("Podaj wagę i wzrost!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool czyPowodzenie = true;

                if (double.TryParse(txtWaga.Text, out _));
                else { 
                    if (string.IsNullOrEmpty(txtWaga.Text))
                    {
                        MessageBox.Show("Podaj swoją wagę w kg!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Waga podana nieprawidłowo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    czyPowodzenie = false;
                }

                if (int.TryParse(txtWzrost.Text, out _)); 
                else
                {
                    if (string.IsNullOrEmpty(txtWaga.Text))
                    {
                        MessageBox.Show("Podaj swój wzrost w cm!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wzrost podany nieprawidłowo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    czyPowodzenie = false;
                }

                if (czyPowodzenie)
                {
                    UstawieniaKlienta();
                }
            }
        }


        private void UstawieniaKlienta()
        {
            List<Klient> klienci = _context.Klienci();
            foreach (var klient in klienci)
            {
                if (klient.KlientID == KlientID)
                {
                    klient.TempoZmian = txtTempo.Value;
                    klient.DataUrodzenia = dateTimePicker1.Value;
                    klient.Waga = double.Parse(txtWaga.Text);
                    klient.Wzrost = int.Parse(txtWzrost.Text);
                    klient.Plec = rbtnMezczyzna.Checked;
                    if (rbtnSchudnie.Checked) { klient.CelZmianWagi = 0; }
                    else if (rbtnUtrzymanie.Checked) { klient.CelZmianWagi = 1; }
                    else { klient.CelZmianWagi = 2; }
                    break;
                }
            }

            _context.ZapiszKlientow(klienci);
            Powrot();
        }

        private void FormUstawien_Load(object sender, EventArgs e)
        {
            WczytajUstawienia();
        }
    }
}
