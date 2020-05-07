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

            PoliczMakroWPosilach();
        }

        public void PoliczMakroWPosilach()
        {
            double bialko = 0;
            double tluszcze = 0;
            double wegle = 0;
            int kcal = 0;

            foreach (var item in _context.Posilki())
            {
                kcal += (item.Gramatura * _context.DajProdukt(item.ProduktId).Kalorie) / 100;
                bialko += (item.Gramatura * _context.DajProdukt(item.ProduktId).Bialko) / 100;
                wegle += (item.Gramatura * _context.DajProdukt(item.ProduktId).Weglowodany) / 100;
                tluszcze += (item.Gramatura * _context.DajProdukt(item.ProduktId).Tluszcze) / 100;
            }

            lblKcalOd.Text = kcal + " kcal";
            lblBialkoOd.Text = bialko + " g";
            lblWeglOd.Text = wegle + " g";
            lblTluszczeOd.Text = tluszcze + " g";
        }

        public void StworzPanelPosilku(int produktID, int posilekID, FlowLayoutPanel panelPos)
        {
            Produkt prod = _context.DajProdukt(produktID);
            int gram = _context.DajPosilek(posilekID).Gramatura;

            Panel panel = new Panel() { 
                Size = new Size(369, 50), 
                BackColor = Color.WhiteSmoke, Visible = true 
            };
            Label lblNazwaIlosc = new Label { 
                AutoSize = true,
                Text = prod.NazwaProduktu + ", " + gram + "g", 
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point)
            };
            Label lblParametry = new Label
            {
                AutoSize = true,
                Text = PoliczParametr(gram, prod.Kalorie) + " kcal,  " + PoliczParametr(gram, prod.Bialko) + "g B,  " 
                + PoliczParametr(gram,prod.Weglowodany) + "g W,  " + PoliczParametr(gram, prod.Tluszcze) + "g T" ,
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(0, 30)
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
            panel.Controls.Add(lblParametry);
            panel.Controls.Add(lblNazwaIlosc);
            panel.Controls.Add(button);
            panelPos.Controls.Add(panel);
        }

        public double PoliczParametr(int gramatura, double parametr)
        {
            decimal kalorie = ((decimal)(gramatura * parametr)) / 100;
            return (double)Math.Round(kalorie, 1, MidpointRounding.AwayFromZero);      
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
            frm.FormClosing += new FormClosingEventHandler((sender, e) => Frm_FormClosing(sender));
            Hide();
        }


        private void Frm_FormClosing(object sender) {

            Form form1 = new Form1
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            form1.Show();
        }

        //--------------------------------- OTWIERANIE OKNA DODAWANIA --------------------------------

        private void btnSniadanie_Click(object sender, EventArgs e){ OtworzOknoDodawania(1);}
        private void btn2Sniad_Click(object sender, EventArgs e){ OtworzOknoDodawania(2); }
        private void btnObiad_Click(object sender, EventArgs e){ OtworzOknoDodawania(3); }
        private void btnDeser_Click(object sender, EventArgs e) {OtworzOknoDodawania(4); }
        private void btnPrzekaska_Click(object sender, EventArgs e){ OtworzOknoDodawania(5); }
        private void btnKolacja_Click(object sender, EventArgs e){ OtworzOknoDodawania(6); }

        //------------------------------ UKRYJ / POKAŻ PANEL NA KLIKNIĘCIE --------------------------

        private void Sniadanie_Click(object sender, EventArgs e) { UkryjPokazPanel(panelSniadanie); }
        private void IISniadanie_Click(object sender, EventArgs e) { UkryjPokazPanel(panel2Sniadanie); }
        private void Obiad_Click(object sender, EventArgs e) { UkryjPokazPanel(panelObiad); }
        private void Deser_Click(object sender, EventArgs e) { UkryjPokazPanel(panelDeser); }
        private void Przekaska_Click(object sender, EventArgs e) { UkryjPokazPanel(panelPrzekaska); }
        private void Kolacja_Click(object sender, EventArgs e) { UkryjPokazPanel(panelKolacja); }

        //------------------------ ZMIANA KURSORA NA 'RĄCZKĘ' PO NAJECHANIU ------------------------------

        private void MouseHand_Sniadanie(object sender, EventArgs e){ Sniadanie.Cursor = Cursors.Hand; }
        private void MouseHand_2Sniadanie(object sender, EventArgs e) { IISniadanie.Cursor = Cursors.Hand; }
        private void MouseHand_Obiad(object sender, EventArgs e) { Obiad.Cursor = Cursors.Hand; }
        private void MouseHand_Deser(object sender, EventArgs e) { Deser.Cursor = Cursors.Hand; }
        private void MouseHand_Przekaska(object sender, EventArgs e) { Przekaska.Cursor = Cursors.Hand; }
        private void MouseHand_Kolacja(object sender, EventArgs e) { Kolacja.Cursor = Cursors.Hand; }

        private void UkryjPokazPanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }
    }
}
