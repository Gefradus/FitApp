using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormRejestracji : Form
    {
        private readonly ModelXML _context;
        bool czyLoginZly = false;
        bool czyHasloZle = false;
        bool czyPotwierdzZle = false;

        public FormRejestracji()
        {
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
            JesliPodanoZle();
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


        private void JesliPodanoZle()
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                lblLogin.ForeColor = Color.Red;
                czyLoginZly = true;
            }
            else
            {
                czyLoginZly = false;
                lblLogin.ForeColor = Color.White;
            }

            if (string.IsNullOrEmpty(txtPass1.Text) || string.IsNullOrWhiteSpace(txtPass1.Text))
            {
                lblHaslo.ForeColor = Color.Red;
                czyHasloZle = true;
            }
            else
            {
                lblHaslo.ForeColor = Color.White;
                czyHasloZle = false;
            }

            if (string.IsNullOrEmpty(txtPass2.Text) || string.IsNullOrWhiteSpace(txtPass2.Text))
            {
                lblPotwierdz.ForeColor = Color.Red;
                czyPotwierdzZle = true;

            }
            else
            {
                lblPotwierdz.ForeColor = Color.White;
                czyPotwierdzZle = false;
            }

            Refresh();
        }

        private void Form1_Paint(PaintEventArgs e)
        {
            RysujLubZresetuj(czyHasloZle, txtPass1, e);
            RysujLubZresetuj(czyPotwierdzZle, txtPass2, e);
            RysujLubZresetuj(czyLoginZly, txtLogin, e);
        }

        private void RysujLubZresetuj(bool coZle, TextBox txt, PaintEventArgs e)
        {
            if (coZle)
            {
                RysujRamke(txt, e);
            }
            else
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void RysujRamke(TextBox txt, PaintEventArgs e)
        {
            txt.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics g = e.Graphics;
            int variance = 2;
            g.DrawRectangle(p, new Rectangle(txt.Location.X - variance, txt.Location.Y - variance,
                txt.Width + variance, txt.Height + variance));
        }

    }
}
