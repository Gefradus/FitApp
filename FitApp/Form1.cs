using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FitApp
{
    public partial class Form1 : Form
    {
        private readonly ModelXML _context;

        public Form1()
        {
            _context = new ModelXML();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context.CreateXMLIfNotExists();
            DodajDzisiajJesliNieMa();
            ZaladujPosilki();
            PoliczKalorieWPosilkach();
        }

        public void ZaladujPosilki()
        {
            foreach (var item in _context.Posilki())
            {
                int posilekID = item.PosilekId;
                int produktID = item.ProduktId;
                if (item.WKtorym == 1) { StworzPanelPosilku(produktID, posilekID, panelSniadanie); }
                if (item.WKtorym == 2) { StworzPanelPosilku(produktID, posilekID, panel2Sniadanie); }
                if (item.WKtorym == 3) { StworzPanelPosilku(produktID, posilekID, panelObiad); }
                if (item.WKtorym == 4) { StworzPanelPosilku(produktID, posilekID, panelDeser); }
                if (item.WKtorym == 5) { StworzPanelPosilku(produktID, posilekID, panelPrzekaska); }
                if (item.WKtorym == 6) { StworzPanelPosilku(produktID, posilekID, panelKolacja); }
            }
        }

        public void PoliczKalorieWPosilkach()
        {
            int kcalSniad = 0;
            int kcal2Sniad = 0;
            int kcalObiad = 0;
            int kcalDeser = 0;
            int kcalPrzekaska = 0;
            int kcalKolacja = 0;

            foreach (var item in _context.Posilki())
            {
                int kalorie = (item.Gramatura * _context.DajProdukt(item.ProduktId).Kalorie) / 100;

                if (item.WKtorym == 1) { kcalSniad += kalorie; }
                if (item.WKtorym == 2) { kcal2Sniad += kalorie; }
                if (item.WKtorym == 3) { kcalObiad += kalorie; }
                if (item.WKtorym == 4) { kcalDeser += kalorie; }
                if (item.WKtorym == 5) { kcalPrzekaska += kalorie; }
                if (item.WKtorym == 6) { kcalKolacja += kalorie; }
            }

            lblSniadanieKcal.Text = kcalSniad + " kcal";
            lbl2SniadKcal.Text = kcal2Sniad + " kcal";
            lblObiadKcal.Text = kcalObiad + " kcal";
            lblDeserKcal.Text = kcalDeser + " kcal";
            lblPrzekaskaKcal.Text = kcalPrzekaska + " kcal";
            lblKolacjaKcal.Text = kcalKolacja + " kcal";
        }


        public void StworzPanelPosilku(int produktID, int posilekID, FlowLayoutPanel panelPos)
        {
            Panel panel = new Panel() { 
                Size = new Size(369, 50), 
                BackColor = Color.WhiteSmoke, Visible = true 
            };
            Label label = new Label { 
                Text = _context.DajProdukt(produktID).NazwaProduktu, 
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
            };
            Button button = new Button()
            {
                Text = "X",
                Size = new Size(30, 30),
                Location = new Point(320, 10),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White

            };

            button.Click += new EventHandler((sender, e) => BtnClick(sender, posilekID));
            panel.Controls.Add(label);
            panel.Controls.Add(button);
            panelPos.Controls.Add(panel);
        }

        public void BtnClick(object sender, int posilekID)
        {
            Button btnClicked = (Button) sender;
            btnClicked.Controls.Owner.Parent.Dispose();
            List<Posilek> posilki = _context.Posilki();

            int i = 0;
            foreach (var item in posilki)
            {
                if (item.PosilekId == posilekID)
                {
                    posilki.RemoveAt(i);
                    break;
                }
                i++;
            }

            _context.ZapiszPosilki(posilki);
            PoliczKalorieWPosilkach();
        }

        public void DodajDzisiajJesliNieMa()
        {
            List<Dzien> dni = _context.Dni();
            if (!CzyJestDzisiaj(dni))
            {
                dni.Add(new Dzien() { 
                    DzienId = _context.AutoIncrementDni(dni), 
                    Dzien1 = DateTime.Now.Date, 
                    Sniadanie = true, 
                    IISniadanie = true, 
                    Obiad = true, 
                    Deser = true, 
                    Kolacja = true, 
                    Przekaska = true 
                }) ;
            }

            _context.ZapiszDni(dni);
        }

        public bool CzyJestDzisiaj(List<Dzien> dni)
        {
            foreach(var item in dni)
            {
                if (item.Dzien1.Date == DateTime.Now.Date)
                {
                    return true;
                }
            }

            return false;
        }

        public void OtworzOknoDodawania(int ktoryPosilek)
        {
            var frm = new FormDodawania
            {
                WKtorym = ktoryPosilek,
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };

            frm.Show();
            frm.FormClosing += Frm_FormClosing;
            Hide();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e){ new Form1().Show(); }
        private void btnSniadanie_Click(object sender, EventArgs e){ OtworzOknoDodawania(1);}
        private void btn2Sniad_Click(object sender, EventArgs e){ OtworzOknoDodawania(2); }
        private void btnObiad_Click(object sender, EventArgs e){ OtworzOknoDodawania(3); }
        private void btnDeser_Click(object sender, EventArgs e) {OtworzOknoDodawania(4); }
        private void btnPrzekaska_Click(object sender, EventArgs e){ OtworzOknoDodawania(5); }
        private void btnKolacja_Click(object sender, EventArgs e){ OtworzOknoDodawania(6); }
    }
}
