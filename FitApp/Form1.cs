using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class Form1 : Form
    {
        private readonly ModelXML _context;
        private readonly Style style;
        public int KlientID { get; set; }
        public int DzienID { get; set; }

        public Form1()
        {
            style = new Style();
            _context = new ModelXML();
            InitializeComponent();
            style.UsunHorizontallScroll(flowLayoutPanel1);
            FormClosing += new FormClosingEventHandler((sender, e) => CloseApplication(e));
        }

        private void CzyPierwszeUruchomienie()
        {
            if (_context.DajKlienta(KlientID).CelBialko == 0) {
                PrzejdzDoUstawien(true);
            }
            else
            {
                OnLoad();
            }

        }

        public void OnLoad()
        {
            _context.CreateXMLIfNotExists();
            DodajDzisiajJesliNieMa();
            if (DzienID == 0)
            {
                DzienID = _context.DajDzisiajID(KlientID);
            }

            Zaladuj();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CzyPierwszeUruchomienie();
        }

        private void PrzejdzDoUstawien(bool czyPierwsze)
        {
            Hide();
            FormUstawien formUstawien = new FormUstawien(KlientID, DzienID, czyPierwsze);
            formUstawien.Show();
        }

        private void Zaladuj()
        {
            ResetPosilkow();
            ZaladujPosilki();
            PoliczKalorieWPosilkach();
            WysrodkujLabele();
            FormatDaty();
        }

        private void WysrodkujLabele()
        {
            style.WysrodkujLabelGorny(pnlPoprzedni, lblPoprzedni1);
            style.WysrodkujLabelDolny(pnlPoprzedni, lblPoprzedni2);
            style.WysrodkujLabelGorny(pnlObecny, lblObecny1);
            style.WysrodkujLabelDolny(pnlObecny, lblObecny2);
            style.WysrodkujLabelGorny(pnlNastepny, lblNastepny1);
            style.WysrodkujLabelDolny(pnlNastepny, lblNastepny2);
        }

        public void FormatDaty()
        {
            DateTime dzienObecny = _context.DajDzien(DzienID).Dzien1.Date;
            DateTime dzienPoprzedni = dzienObecny.AddDays(-1);
            DateTime dzienNastepny = dzienObecny.AddDays(1);

            lblPoprzedni1.Text = DajDzienTygodnia(dzienPoprzedni);
            lblObecny1.Text = DajDzienTygodnia(dzienObecny);
            lblNastepny1.Text = DajDzienTygodnia(dzienNastepny);

            lblPoprzedni2.Text = dzienPoprzedni.Day + DajMiesiac(dzienPoprzedni.Month);
            lblObecny2.Text = dzienObecny.Day + DajMiesiac(dzienObecny.Month);
            lblNastepny2.Text = dzienNastepny.Day + DajMiesiac(dzienNastepny.Month);
        }

        private string DajDzienTygodnia(DateTime dzien)
        {
            if (dzien == DateTime.Now.Date) { return "Dzisiaj"; }
            if (dzien.Date == DateTime.Now.Date.AddDays(-1)) { return "Wczoraj"; }
            if (dzien.Date == DateTime.Now.Date.AddDays(1)) { return "Jutro"; }
            if (((int)dzien.DayOfWeek) == 0) { return "Nie"; }
            if (((int)dzien.DayOfWeek) == 1) { return "Pon"; }
            if (((int)dzien.DayOfWeek) == 2) { return "Wto"; }
            if (((int)dzien.DayOfWeek) == 3) { return "Śro"; }
            if (((int)dzien.DayOfWeek) == 4) { return "Czw"; }
            if (((int)dzien.DayOfWeek) == 5) { return "Piąt"; }
            if (((int)dzien.DayOfWeek) == 6) { return "Sob"; }
            return "";
        }

        static public string DajMiesiac(int month)
        {
            if (month == 1) { return "sty"; }
            if (month == 2) { return "lut"; }
            if (month == 3) { return "mar"; }
            if (month == 4) { return "kwi"; }
            if (month == 5) { return "maj"; }
            if (month == 6) { return "czer"; }
            if (month == 7) { return "lip"; }
            if (month == 8) { return "sie"; }
            if (month == 9) { return "wrz"; }
            if (month == 10) { return "paź"; }
            if (month == 11) { return "lis"; }
            if (month == 12) { return "gru"; }
            return "";
        }

        private void NarysujPaski(int kcal, double bialko, double wegle, double tluszcze)
        {
            Dzien dzien = _context.DajDzien(DzienID);
            pnlKcal.Width = style.DlugoscPaska(pasekKcal, kcal, dzien.CelKalorii);
            pnlBialko.Width = style.DlugoscPaska(pasekBialko, bialko, dzien.CelBialko);
            pnlWegle.Width = style.DlugoscPaska(pasekWegl, wegle, dzien.CelWegle);
            pnlTluszcze.Width = style.DlugoscPaska(pasekTluszcze, tluszcze, dzien.CelTluszcze);
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
                BackColor = Color.FromArgb(230, 230, 230), Visible = true 
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

            Button btnEdytuj = new Button()
            {
                Size = new Size(60, 27),
                Location = new Point(270, 12),
                Text = "Edytuj",
                Font = new Font("Arial", 9.5F, GraphicsUnit.Point),
                BackColor = Color.Gray,
                ForeColor = Color.White
            };

            Button btnDelete = new Button()
            {
                Size = new Size(27, 27),
                Location = new Point(333, 12),
                Text = "X",
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point),
                BackColor = Color.FromArgb(233,32,32),
                ForeColor = Color.White
            };

            btnEdytuj.Click += new EventHandler((sender, e) => EdytujPosilek(posilekID));
            btnDelete.Click += new EventHandler((sender, e) => BtnDeleteClick(sender, posilekID));
            panel.Controls.Add(lblParametry);
            panel.Controls.Add(btnEdytuj);
            panel.Controls.Add(lblNazwaIlosc);
            panel.Controls.Add(btnDelete);
            panelPos.Controls.Add(panel);
        }

        private void EdytujPosilek(int posilekID)
        {
            FormEdytujPosilek formEdytuj = new FormEdytujPosilek { 
                PosilekID = posilekID, 
                Form1 = this
            };
            formEdytuj.ShowDialog(this);
        }


        private void ResetPosilkow()
        {
            panelSniadanie.Controls.Clear();
            panel2Sniadanie.Controls.Clear();
            panelObiad.Controls.Clear();
            panelDeser.Controls.Clear();
            panelPrzekaska.Controls.Clear();
            panelKolacja.Controls.Clear();
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
                "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
                    CelKalorii = _context.DajKlienta(KlientID).CelKalorii,
                    CelBialko = _context.DajKlienta(KlientID).CelBialko,
                    CelTluszcze = _context.DajKlienta(KlientID).CelTluszcze,
                    CelWegle = _context.DajKlienta(KlientID).CelWegle,  
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
            formDodawania.FormClosing += new FormClosingEventHandler((sender, e) => FormDodawania_Closing());
            Hide();
        }

        private void CloseApplication(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zamknąć?", "Potwierdzenie wylogowania",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();
                FormLogowania formLogowania = new FormLogowania();
                formLogowania.Show();
                formLogowania.FormClosing += new FormClosingEventHandler(formLogowania.CloseApp);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormDodawania_Closing() {
            Form form1 = new Form1
            {
                StartPosition = FormStartPosition.CenterScreen,
                KlientID = KlientID,
                DzienID = DzienID
            };

            form1.Show();
            
        }

        //--------------------------------- OTWIERANIE OKNA DODAWANIA --------------------------------

        private void BtnSniadanie_Click(object sender, EventArgs e){ OtworzOknoDodawania(1);}
        private void Btn2Sniad_Click(object sender, EventArgs e){ OtworzOknoDodawania(2); }
        private void BtnObiad_Click(object sender, EventArgs e){ OtworzOknoDodawania(3); }
        private void BtnDeser_Click(object sender, EventArgs e) {OtworzOknoDodawania(4); }
        private void BtnPrzekaska_Click(object sender, EventArgs e){ OtworzOknoDodawania(5); }
        private void BtnKolacja_Click(object sender, EventArgs e){ OtworzOknoDodawania(6); }

        //------------------------------ UKRYJ / POKAŻ PANEL NA KLIKNIĘCIE --------------------------

        private void Sniadanie_Click(object sender, EventArgs e) { UkryjPokazPanel(panelSniadanie); }
        private void IISniadanie_Click(object sender, EventArgs e) { UkryjPokazPanel(panel2Sniadanie); }
        private void Obiad_Click(object sender, EventArgs e) { UkryjPokazPanel(panelObiad); }
        private void Deser_Click(object sender, EventArgs e) { UkryjPokazPanel(panelDeser); }
        private void Przekaska_Click(object sender, EventArgs e) { UkryjPokazPanel(panelPrzekaska); }
        private void Kolacja_Click(object sender, EventArgs e) { UkryjPokazPanel(panelKolacja); }

        private void UkryjPokazPanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        //------------------------ ZMIANA KURSORA NA 'RĄCZKĘ' PO NAJECHANIU ------------------------------
        private void MouseHand_Poprzedni(object sender, EventArgs e) {
            WyczyscZaznaczenie(sender, e);
            pnlPoprzedni.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void MouseHand_Obecny(object sender, EventArgs e) { 
            WyczyscZaznaczenie(sender, e);
            pnlObecny.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void MouseHand_Nastepny(object sender, EventArgs e) { 
            WyczyscZaznaczenie(sender, e);
            pnlNastepny.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void WyczyscZaznaczenie(object sender, EventArgs e)
        {
            pnlPoprzedni.BackColor = Color.White;
            pnlObecny.BackColor = Color.White;
            pnlNastepny.BackColor = Color.White;
        }

        private void MouseHand_Settings(object sender, EventArgs e) { 
            panelUstawien.Cursor = Cursors.Hand;
            panelUstawien.BackColor = Color.GhostWhite;
            btnSettings.BackColor = Color.GhostWhite;
        }

        private void MouseLeave_Settings(object sender, EventArgs e)
        {
            panelUstawien.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
        }


        //------------------------------------- ZMIANA DNIA -------------------------------------------

        private void PnlPoprzedni_Click(object sender, EventArgs e) {
            SprawdzCzyJestDzien(-1);
        }
        private void PnlObecny_Click(object sender, EventArgs e) {
            
        }
        private void PnlNastepny_Click(object sender, EventArgs e) {
            SprawdzCzyJestDzien(1);
        }

        private void SprawdzCzyJestDzien(int ktory)
        {

            bool jestDzien = false;
            foreach (var klient in _context.Klienci())
            {
                if (klient.KlientID == _context.DajKlientaPoDniuID(DzienID))
                {
                    foreach (var dzien in _context.Dni())
                    {
                        if (dzien.KlientId == klient.KlientID)
                        {
                            if (dzien.Dzien1 == _context.DajDzien(DzienID).Dzien1.AddDays(ktory))
                            {
                                DzienID = dzien.DzienId;
                                jestDzien = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!jestDzien)
            {
                List<Dzien> dni = _context.Dni();
                int nowyDzienID = _context.AutoIncrementDni(dni);
                dni.Add(new Dzien()
                {
                    DzienId = nowyDzienID,
                    KlientId = KlientID,
                    Dzien1 = _context.DajDzien(DzienID).Dzien1.AddDays(ktory),
                    CelBialko = _context.DajKlienta(KlientID).CelBialko,
                    CelWegle = _context.DajKlienta(KlientID).CelWegle,
                    CelTluszcze = _context.DajKlienta(KlientID).CelTluszcze,
                    CelKalorii = _context.DajKlienta(KlientID).CelKalorii
                });

                _context.ZapiszDni(dni);
                DzienID = nowyDzienID;
            }

            Zaladuj();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            PrzejdzDoUstawien(false);
        }


        private void Logo_Click(object sender, EventArgs e)
        {
            DzienID = 0;
            OnLoad();
        }

        private void PaintBorder(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, Border.Width, 1);
        }
    }
}
