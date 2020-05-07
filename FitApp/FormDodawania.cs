using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FitApp
{
    public partial class FormDodawania : Form
    {
        private readonly ModelXML _context = new ModelXML();
        public int ktoryPosilekDnia { get; set; }

        public FormDodawania()
        {
            InitializeComponent();
        }

        private void FormDodawania_Load(object sender, EventArgs e)
        {
            Ojezu();

            foreach (var item in _context.Produkty())
            {
                comboBox1.Items.Add(item.NazwaProduktu);
            }

        }


        public void Ojezu()
        {
            if (ktoryPosilekDnia == 1) { label1.Text = "Śniadanie"; }
            if (ktoryPosilekDnia == 2) { label1.Text = "II śniadanie"; }
            if (ktoryPosilekDnia == 3) { label1.Text = "Obiad"; }
            if (ktoryPosilekDnia == 4) { label1.Text = "Deser"; }
            if (ktoryPosilekDnia == 5) { label1.Text = "Przekąska"; }
            if (ktoryPosilekDnia == 6) { label1.Text = "Kolacja"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Posilek> posilki = _context.Posilki();

            posilki.Add(new Posilek() { 
                PosilekId = AIPosilki(posilki), 
                Gramatura = 200, 
                WKtorym = 1, 
                ProduktId = 2, 
                DzienId = 1 
            });
            posilki.Add(new Posilek()
            {
                PosilekId = AIPosilki(posilki),
                Gramatura = 200,
                WKtorym = 1,
                ProduktId = 1,
                DzienId = 1
            });
            posilki.Add(new Posilek()
            {
                PosilekId = AIPosilki(posilki),
                Gramatura = 200,
                WKtorym = 2,
                ProduktId = 1,
                DzienId = 1
            });



            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\posilek.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(List<Posilek>)).Serialize(fs, posilki);
            }
        }


        public int AIPosilki(List<Posilek> listaPosilkow)
        {
            int i = 0;
            foreach (var item in listaPosilkow)
            {
                i++;
            }

            return i;
        }
    }
}
