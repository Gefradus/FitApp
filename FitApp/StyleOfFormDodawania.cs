using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    class StyleOfFormDodawania
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
            txtBoxSearch.ForeColor = System.Drawing.Color.Gray;
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
                txtBoxSearch.ForeColor = System.Drawing.Color.Black;
                txtBoxSearch.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSearch.Text))
            {
                txtBoxSearch.Text = "Szukaj produktu";
                txtBoxSearch.ForeColor = System.Drawing.Color.Gray;
            }   
        }
    }
}
