using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    class Walidacja
    {

        public bool CzyZnakToPrzecinek(char c)
        {
            return c.ToString().Contains(',') || c.ToString().Contains('.');
        }

        public void WalidacjaTextBoxa(TextBox textBox, int maxZnakow, bool czyPrzecinkiDozwolone, int max)
        {
            char[] text = textBox.Text.ToCharArray();
            List<char> textPoWalidacji = new List<char>();
            bool czyJestPrzecinek = false;
            bool czyJestCosPoPrzecinku = false;

            for (int i = 0; i < text.Length; i++)
            {
                if ((int.TryParse(text[i].ToString(), out _) || (czyPrzecinkiDozwolone && 
                    CzyZnakToPrzecinek(text[i]) && !czyJestPrzecinek && text.Length > 1)) && !czyJestCosPoPrzecinku)
                {
                    if (CzyZnakToPrzecinek(text[i]))
                    {
                        czyJestPrzecinek = true;
                    }
                    else
                    {
                        if (czyJestPrzecinek)
                        {
                            czyJestCosPoPrzecinku = true;
                        }
                    }

                    textPoWalidacji.Add(text[i]);
                }
            }
            

            if (czyJestPrzecinek) { maxZnakow += 2; }

            List<char> zwalidowanyTekst = new List<char>();
            foreach (var znak in textPoWalidacji)
            {
                zwalidowanyTekst.Add(znak.ToString().Replace('.', ',')[0]);
            }

            string textPoWal = "";
            int ileWypisano = 0;
            foreach (var znak in zwalidowanyTekst)
            {
                textPoWal += znak;
                ileWypisano++;

                if (ileWypisano >= maxZnakow)
                {
                    break;
                }
            }

            try
            {
                if (double.Parse(textPoWal) > max)
                {
                    textPoWal = max.ToString();
                }
            }
            catch {}

            textBox.Text = textPoWal;

        }

    }
}
