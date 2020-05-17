using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    class Style
    {
        private TextBox txtBoxSearch;
        private Panel panelGlowny;
        private Panel panelGorny;
        private Panel panelSearch;
        private Label NazwaPosilku;
        private Button btnHidden;

        public void CreatePlaceholderText(TextBox txtBoxSearch, Panel panelGlowny, Panel panelGorny,
            Panel panelSearch, Label NazwaPosilku, Button btnHidden)
        {

            ControlsSetter(txtBoxSearch, panelGlowny, panelGorny, panelSearch, NazwaPosilku, btnHidden);
            LostFocusWhenClickOutside();
            txtBoxSearch.Text = "Szukaj produktu";
            txtBoxSearch.ForeColor = Color.Gray;
            txtBoxSearch.GotFocus += new EventHandler(RemoveText);
            txtBoxSearch.LostFocus += new EventHandler(AddText);
        }

        public void ControlsSetter(TextBox txtBoxSearch, Panel panelGlowny, Panel panelGorny,
            Panel panelSearch, Label NazwaPosilku, Button btnHidden)
        {
            this.txtBoxSearch = txtBoxSearch;
            this.panelGlowny = panelGlowny;
            this.panelGorny = panelGorny;
            this.panelSearch = panelSearch;
            this.NazwaPosilku = NazwaPosilku;
            this.btnHidden = btnHidden;
        }

        public void LostFocusWhenClickOutside()
        {
            NazwaPosilku.Click += LostFocus;
            panelGlowny.Click += LostFocus;
            panelSearch.Click += LostFocus;
            panelGorny.Click += LostFocus;
        }

        public void LostFocus(object sender, EventArgs e)
        {
            btnHidden.Focus();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "Szukaj produktu")
            {
                txtBoxSearch.ForeColor = Color.Black;
                txtBoxSearch.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSearch.Text))
            {
                txtBoxSearch.Text = "Szukaj produktu";
                txtBoxSearch.ForeColor = Color.Gray;
            }   
        }


        public void RysujLubZresetuj(bool coZle, TextBox txt, PaintEventArgs e)
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

        public void RysujRamke(TextBox txt, PaintEventArgs e)
        {
            txt.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics g = e.Graphics;
            int variance = 2;
            g.DrawRectangle(p, new Rectangle(txt.Location.X - variance, txt.Location.Y - variance,
                txt.Width + variance, txt.Height + variance));
        }

        public void UsunHorizontallScroll(Panel panel)
        {
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = false;
            panel.VerticalScroll.Visible = false;
            panel.AutoScroll = true;
        }

        public void WysrodkujLabelGorny(Panel panel, Label label)
        {
            label.Location = new Point((panel.Width - label.Width) / 2, 5);
        }

        public void WysrodkujLabelDolny(Panel panel, Label label)
        {
            label.Location = new Point((panel.Width - label.Width) / 2, 30);
        }

        public int DlugoscPaska(Panel pasek, double parametr, int cel, Panel panelPostepu, Color kolorDomyslny)
        {
            if (!(cel == 0))
            {
                if ((parametr / cel) > 1)
                {
                    panelPostepu.BackColor = Color.Red;
                }
                else
                {
                    panelPostepu.BackColor = kolorDomyslny;
                }

                return (int)(pasek.Width * (parametr / cel));
            }
            else
            {
                return pasek.Width;
            }

        }

    }
}
