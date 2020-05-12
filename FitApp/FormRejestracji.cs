using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormRejestracji : Form
    {
        private readonly Style style;
        private readonly ModelXML _context;
        private bool czyLoginZly = false;
        private bool czyHasloZle = false;
        private bool czyPotwierdzZle = false;

        public FormRejestracji()
        {
            style = new Style();
            _context = new ModelXML();
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => Frm_FormClosing());
            Paint += new PaintEventHandler((sender, e) => Form1_Paint(e));
        }

        private void Frm_FormClosing()
        {
            Hide();
            new FormLogowania().Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            JesliNiePodano();
            Zarejestruj();
        }

        private void Zarejestruj()
        {
            if (!czyHasloZle && !czyLoginZly && !czyPotwierdzZle)
            {
                bool czyZajeta = false;

                foreach (var klient in _context.Klienci())
                {
                    if (klient.Login.ToLower() == txtLogin.Text.ToLower())
                    {
                        czyZajeta = true;
                        MessageBox.Show("Podana nazwa użytkownika jest już zajęta!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!czyZajeta)
                {
                    SprawdzPoprawnosc();
                }
            }
        }

        private void SprawdzPoprawnosc()
        {
            if (txtPass1.Text == txtPass2.Text)
            {
                if (txtPass1.Text.Length < 7)
                {
                    if (txtLogin.Text.Length < 7)
                    {
                        MessageBox.Show("Haslo i login muszą zawierać co najmniej 7 znaków!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Haslo musi zawierać co najmniej 7 znaków!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txtLogin.Text.Length < 7)
                {
                    MessageBox.Show("Login musi zawierać co najmniej 7 znaków!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DodajKlienta();
                }
            }
            else
            {
                MessageBox.Show("Podane hasła nie zgadzają się ze sobą!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
        }


        private void DodajKlienta()
        {    
            List<Klient> klienci = _context.Klienci();
            int klientID = _context.AutoIncrementKlientow(klienci);
            klienci.Add(new Klient()
            {
                KlientID = klientID,
                Login = txtLogin.Text,
                Haslo = txtPass1.Text,
            });

            _context.ZapiszKlientow(klienci);
            MessageBox.Show("Pomyślna rejestracja.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            FormUstawien formUstawien = new FormUstawien(klientID, _context.DajDzisiajID(klientID), true);
            formUstawien.Show();
        }


        private void JesliNiePodano()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text)) { lblLogin.ForeColor = Color.Red; czyLoginZly = true; }
            else { lblLogin.ForeColor = Color.White; czyLoginZly = false; }

            if (string.IsNullOrWhiteSpace(txtPass1.Text)) { lblHaslo.ForeColor = Color.Red; czyHasloZle = true; }
            else { lblHaslo.ForeColor = Color.White; czyHasloZle = false; }

            if (string.IsNullOrWhiteSpace(txtPass2.Text)) { lblPotwierdz.ForeColor = Color.Red; czyPotwierdzZle = true; }
            else { lblPotwierdz.ForeColor = Color.White; czyPotwierdzZle = false; }

            Refresh();
        }

        private void Form1_Paint(PaintEventArgs e)
        {
            style.RysujLubZresetuj(czyHasloZle, txtPass1, e);
            style.RysujLubZresetuj(czyPotwierdzZle, txtPass2, e);
            style.RysujLubZresetuj(czyLoginZly, txtLogin, e);
        }

        private void NiePozwalajNaBialeZnaki(object sender, EventArgs e)
        {
            Walidacja.NiePozwalajNaBialeZnaki(sender);
        }
    }
}
