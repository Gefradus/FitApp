using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormUstawien : Form
    {
        private readonly Walidacja walidacja;
        private readonly ModelXML _context;
        public int KlientID { get; set; }
        public int DzienID { get; set; }
        public bool CzyPierwszeUruchomienie { get; set; }

        public FormUstawien(int klientID, int dzienID, bool czyPierwsze)
        {
            walidacja = new Walidacja();
            _context = new ModelXML();
            UstawSettery(klientID, dzienID, czyPierwsze);
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(Form_Closing);
        }

        private void UstawSettery(int klientID, int dzienID, bool czyPierwsze)
        {
            KlientID = klientID;
            DzienID = dzienID;
            CzyPierwszeUruchomienie = czyPierwsze;
        }

        private void FormUstawien_Load(object sender, EventArgs e)
        {
            WczytajUstawienia();
        }

        private void Powrot()
        {
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

            Hide();
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

                if (klient.CelZmianWagi == 1) { rbtnSchudnie.Checked = true; }
                else if(klient.CelZmianWagi == 2) { rbtnUtrzymanie.Checked = true; }
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
                    if(int.Parse(txtWzrost.Text) < 120)
                    {
                        MessageBox.Show("Wzrost musi wynosić przynajmniej 120cm!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(double.Parse(txtWaga.Text) < 15)
                        {
                            MessageBox.Show("Waga musi wynosić przynajmniej 15kg!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            UstawieniaKlienta();
                        }
                    }
                }
            }
        }


        private void UstawieniaKlienta()
        {
            List<Klient> klienci = _context.Klienci();
            int celKalorii = 0, celBialko = 0, celTluszcze = 0, celWegle = 0;

            foreach (var klient in klienci)
            {
                if (klient.KlientID == KlientID)
                {
                    decimal tempo = txtTempo.Value;
                    DateTime dataUro = dateTimePicker1.Value;
                    double waga = double.Parse(txtWaga.Text);
                    int wzrost = int.Parse(txtWzrost.Text);
                    bool plec = rbtnMezczyzna.Checked;
                    short celZmianWagi;

                    if (rbtnSchudnie.Checked) { celZmianWagi = 1; }
                    else if (rbtnUtrzymanie.Checked) { celZmianWagi = 2; }
                    else { celZmianWagi = 3; }

                    int zapotrzebowanie = ObliczCele.ObliczZapotrzebowanie(plec, dataUro, wzrost, waga);
                    celKalorii = ObliczCele.ObliczCelKalorii(zapotrzebowanie, celZmianWagi, tempo);
                    celBialko = ObliczCele.ObliczCelBialko(waga, celKalorii);
                    celTluszcze = ObliczCele.ObliczCelTluszcze(celKalorii);
                    celWegle = ObliczCele.ObliczCelWegle(celKalorii, celBialko, celTluszcze);

                    klient.CelWegle = celWegle;
                    klient.CelTluszcze = celBialko;
                    klient.CelBialko = celTluszcze;
                    klient.CelKalorii = celKalorii;
                    klient.TempoZmian = tempo;
                    klient.DataUrodzenia = dataUro;
                    klient.Waga = waga;
                    klient.Wzrost = wzrost;
                    klient.Plec = plec;
                    klient.CelZmianWagi = celZmianWagi;
                    break;
                }
            }

            _context.ZapiszKlientow(klienci);
            ZmienUstawieniaDni(celKalorii, celBialko, celTluszcze, celWegle);
            CzyPierwszeUruchomienie = false;
            Powrot();
        }

        private void ZmienUstawieniaDni(int celKalorii, int celBialko, int celTluszcze, int celWegle)
        {
            if (!CzyPierwszeUruchomienie)
            {
                List<int> listaDniOdDzisID = new List<int>();
                foreach (var dzien in _context.Dni())
                {
                    if (dzien.KlientId == KlientID && dzien.Dzien1.Date >= DateTime.Now.Date)
                    {
                        listaDniOdDzisID.Add(dzien.DzienId);
                    }
                }

                List<Dzien> wszystkieDni = _context.Dni();
                foreach (var dzienOdDzisID in listaDniOdDzisID)
                {
                    foreach (var dzienOdDzis in wszystkieDni)
                    {
                        if (dzienOdDzis.DzienId == dzienOdDzisID)
                        {
                            dzienOdDzis.CelKalorii = celKalorii;
                            dzienOdDzis.CelBialko = celBialko;
                            dzienOdDzis.CelTluszcze = celTluszcze;
                            dzienOdDzis.CelWegle = celWegle;
                        }
                    }
                }

                _context.ZapiszDni(wszystkieDni);
 
            }
        }

        private void RbtnUtrzymanie_CheckedChanged(object sender, EventArgs e)
        {
            txtTempo.Enabled = !rbtnUtrzymanie.Checked;
        }

        private void TxtWaga_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa(txtWaga, 4, true, 600);
        }

        private void TxtWzrost_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa(txtWzrost, 3, true, 300);
        }
    }
}
