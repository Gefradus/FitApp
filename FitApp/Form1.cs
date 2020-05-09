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
        public int KlientID { get; set; }
        public int DzienID { get; set; }

        public Form1()
        {
            _context = new ModelXML();
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => CloseApplication());
        }

        private void Form1_Load(object sender, EventArgs e)
        {     
            _context.CreateXMLIfNotExists();
            DodajDzisiajJesliNieMa();
            DzienID = _context.DajDzisiajID(KlientID);
            ZaladujPosilki();
            PoliczKalorieWPosilkach();
            WysrodkujLabele();
        }


        private void WysrodkujLabele()
        {
            WysrodkujLabelWPanelu(pnlPoprzedni, lblPoprzedni1);
            WysrodkujLabelWPanelu(pnlPoprzedni, lblPoprzedni2);
            WysrodkujLabelWPanelu(pnlObecny, lblObecny1);
            WysrodkujLabelWPanelu(pnlObecny, lblObecny2);
            WysrodkujLabelWPanelu(pnlNastepny, lblNastepny1);
            WysrodkujLabelWPanelu(pnlNastepny, lblNastepny2);
        }

        private void WysrodkujLabelWPanelu(TableLayoutPanel panel, Label label)
        {
            label.Margin = new Padding((panel.Width - label.Width) / 2, 5, 0, 0);
        }

        private void NarysujPaski(int kcal, double bialko, double wegle, double tluszcze)
        {
            Dzien dzien = _context.DajDzien(DzienID);
            pnlKcal.Width = DlugoscPaska(pasekKcal, kcal, dzien.CelKalorii);
            pnlBialko.Width = DlugoscPaska(pasekBialko, bialko, dzien.CelBialko);
            pnlWegle.Width = DlugoscPaska(pasekWegl, wegle, dzien.CelWegle);
            pnlTluszcze.Width = DlugoscPaska(pasekTluszcze, tluszcze, dzien.CelTluszcze);
        }

        private int DlugoscPaska(Panel pasek, double parametr, int cel)
        {
            if (!(cel == 0))
            {
                return (int)(pasek.Width * (parametr / cel));
            }
            else
            {
                return pasek.Width;
            }
        }


        private void ZaladujPosilki()
        {
            foreach (var item in _context.Posilki())
            {
                if (_context.CzyPosilekWDanymDniu(item.PosilekId, DzienID))
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
        }

        private void PoliczKalorieWPosilkach()
        {
            int kcalSniad = 0, kcal2Sniad = 0, kcalObiad = 0, kcalDeser = 0, kcalPrzekaska = 0, kcalKolacja = 0;

            foreach (var item in _context.Posilki())
            {
                if (_context.CzyPosilekWDanymDniu(item.PosilekId, DzienID))
                {
                    int kalorie = (item.Gramatura * _context.DajProdukt(item.ProduktId).Kalorie) / 100;

                    if (item.WKtorym == 1) { kcalSniad += kalorie; }
                    if (item.WKtorym == 2) { kcal2Sniad += kalorie; }
                    if (item.WKtorym == 3) { kcalObiad += kalorie; }
                    if (item.WKtorym == 4) { kcalDeser += kalorie; }
                    if (item.WKtorym == 5) { kcalPrzekaska += kalorie; }
                    if (item.WKtorym == 6) { kcalKolacja += kalorie; }
                }
            }

            lblSniadanieKcal.Text = kcalSniad + " kcal";
            lbl2SniadKcal.Text = kcal2Sniad + " kcal";
            lblObiadKcal.Text = kcalObiad + " kcal";
            lblDeserKcal.Text = kcalDeser + " kcal";
            lblPrzekaskaKcal.Text = kcalPrzekaska + " kcal";
            lblKolacjaKcal.Text = kcalKolacja + " kcal";

            PoliczMakroWPosilach();
        }

        private void PoliczMakroWPosilach()
        {
            double bialko = 0, tluszcze = 0, wegle = 0;
            int kcal = 0;

            foreach (var item in _context.Posilki())
            {
                if (_context.CzyPosilekWDanymDniu(item.PosilekId, DzienID))
                {
                    kcal += (item.Gramatura * _context.DajProdukt(item.ProduktId).Kalorie) / 100;
                    bialko += (item.Gramatura * _context.DajProdukt(item.ProduktId).Bialko) / 100;
                    wegle += (item.Gramatura * _context.DajProdukt(item.ProduktId).Weglowodany) / 100;
                    tluszcze += (item.Gramatura * _context.DajProdukt(item.ProduktId).Tluszcze) / 100;
                }
            }

            lblKcalOd.Text = "Kcal: "+ kcal + " /";
            lblBialkoOd.Text = "Białko: "+ Zaokraglij((decimal)bialko, 0) + " /";
            lblWeglOd.Text = "Węgl.: "+ Zaokraglij((decimal)wegle, 0) + " /";
            lblTluszczeOd.Text = "Tł.: "+ Zaokraglij((decimal)tluszcze, 0) + " /";

            Dzien dzien = _context.DajDzien(DzienID);
            lblKcalDo.Text = dzien.CelKalorii + " kcal";
            lblBialkoDo.Text = dzien.CelBialko + " g";
            lblWeglDo.Text = dzien.CelWegle + " g";
            lblTluszczeDo.Text = dzien.CelTluszcze + " g";

            NarysujPaski(kcal, Zaokraglij((decimal)bialko, 0), Zaokraglij((decimal)wegle, 0), Zaokraglij((decimal)tluszcze, 0));
        }


        private void StworzPanelPosilku(int produktID, int posilekID, FlowLayoutPanel panelPos)
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

            Button btnDelete = new Button()
            {
                Text = "X",
                Size = new Size(30, 30),
                Location = new Point(320, 10),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White
            };

            btnDelete.Click += new EventHandler((sender, e) => BtnDeleteClick(sender, posilekID));
            panel.Controls.Add(lblParametry);
            panel.Controls.Add(lblNazwaIlosc);
            panel.Controls.Add(btnDelete);
            panelPos.Controls.Add(panel);
        }

        private double Zaokraglij(decimal liczba, int ilePoPrzecinku)
        {
            return (double)Math.Round(liczba, ilePoPrzecinku, MidpointRounding.AwayFromZero);
        }

        private double PoliczParametr(int gramatura, double parametr)
        {
            return Zaokraglij(((decimal)(gramatura * parametr)) / 100, 1);      
        }

        private void BtnDeleteClick(object sender, int posilekID)
        {
            Posilek posilek = _context.DajPosilek(posilekID);
            string nazwa = _context.DajProdukt(posilek.ProduktId).NazwaProduktu;
            
            if (DialogResult.Yes == MessageBox.Show("Czy na pewno chcesz usunąć "+nazwa+", "+posilek.Gramatura+"g?", 
                "Potwierdzenie usunięcia", MessageBoxButtons.YesNo))
            {
                Button btnClicked = (Button)sender;
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
        }

        private void DodajDzisiajJesliNieMa()
        {
            List<Dzien> dni = _context.Dni();
            if (!_context.CzyJestDzisiaj(KlientID))
            { 
                dni.Add(new Dzien()
                {
                    DzienId = _context.AutoIncrementDni(dni),
                    Dzien1 = DateTime.Now.Date,
                    KlientId = KlientID,
                /*    Sniadanie = true,
                    IISniadanie = true,
                    Obiad = true,
                    Deser = true,
                    Kolacja = true,
                    Przekaska = true*/
                });
            }

            _context.ZapiszDni(dni);
        }


        private void OtworzOknoDodawania(int ktoryPosilek)
        {
            var formDodawania = new FormDodawania
            {
                WKtorym = ktoryPosilek,
                DzienID = DzienID,
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };

            formDodawania.Show();
            formDodawania.FormClosing += new FormClosingEventHandler((sender, e) => Frm_FormClosing());
            Hide();
        }

        private void CloseApplication()
        {
            try
            {
                Application.ExitThread();
            }
            catch { }
        }

        private void Frm_FormClosing() {

            Form form1 = new Form1
            {
                StartPosition = FormStartPosition.CenterScreen,
                KlientID = KlientID,
                DzienID = DzienID
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
