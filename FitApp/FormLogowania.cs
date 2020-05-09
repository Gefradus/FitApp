using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormLogowania : Form
    {
        private readonly ModelXML _context = new ModelXML();

        public FormLogowania()
        {
            InitializeComponent();
        }

        private void FormLogowania_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool czyZalogowano = false;
            foreach(var klient in _context.Klienci())
            {
                if(txtLogin.Text.ToLower() == klient.Login.ToLower() && txtHaslo.Text == klient.Haslo)
                {
                    czyZalogowano = true;
                    Hide();
                    Form1 form1 = new Form1 { KlientID = klient.KlientID };
                    form1.Show();
                }
            }

            if (!czyZalogowano)
            {
                if (string.IsNullOrEmpty(txtHaslo.Text))
                {
                    if (string.IsNullOrEmpty(txtLogin.Text))
                    {
                        MessageBox.Show("Podaj login i hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Podaj hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    MessageBox.Show("Podaj login!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login i/lub hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRejestracji().Show();
        }
    }
}
