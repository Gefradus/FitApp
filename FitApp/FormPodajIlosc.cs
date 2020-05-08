using System;
using System.Collections;
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
    public partial class FormPodajIlosc : Form
    {

        private readonly ModelXML _context = new ModelXML();
        public int ProduktID { get; set; }
        public int WKtorym { get; set; }

        public FormPodajIlosc()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => Powrot());
        }

    private void PodajLiczbeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((!int.TryParse(e.KeyChar+"", out _) || textBox1.Text.Length > 5) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

        private void btnDodaj_Click(object sender, EventArgs e)
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
                List<Posilek> posilki = _context.Posilki();
                posilki.Add(new Posilek()
                {
                    DzienId = 1,
                    Gramatura = int.Parse(textBox1.Text),
                    PosilekId = _context.AutoIncrementPosilki(_context.Posilki()),
                    ProduktId = dodawanyProduktID,
                    WKtorym = WKtorym
                });

                _context.ZapiszPosilki(posilki);

                Form form1 = new Form1 { StartPosition = FormStartPosition.CenterScreen };
                form1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Należy podać ilość produktu w gramach!");
            }
        }

        private void Powrot()
        {
            FormDodawania form = new FormDodawania { StartPosition = FormStartPosition.CenterScreen };
            form.FormClosing += new FormClosingEventHandler((sender, e) => form.ZamknijForme());
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] text = textBox1.Text.ToCharArray();
            List<char> textPoWalidacji = new List<char>();

            for(int i = 0; i < text.Length; i++)
            {
                if (int.TryParse(text[i]+"", out _))
                {
                    textPoWalidacji.Add(text[i]);
                }
            }

            string textPoWal = "";
            foreach(var znak in textPoWalidacji)
            {
                textPoWal += znak;
            }

            textBox1.Text = textPoWal;
        }
    }
}
