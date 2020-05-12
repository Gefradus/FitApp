using System;

namespace FitApp
{
    public class ObliczCele
    {
        static public int ObliczCelKalorii(int zapotrzebowanie, short celZmian, decimal tempo)
        {
            //-----------------------------schudnięcie--------------------------
            if (celZmian == 1)
            {
                int celKcal = (int)(zapotrzebowanie - (tempo * 1100));

                if (celKcal <= 1000)
                {
                    return 1000;
                }
                else
                {
                    return celKcal;
                }
            }

            //-----------------------------przytycie--------------------------
            if (celZmian == 3)
            {
                int celKcal = (int)(zapotrzebowanie + (tempo * 1100));

                if (celKcal <= 1000)
                {
                    return 1000;
                }
                else
                {
                    return celKcal;
                }
            }

            //-----------------------------utrzymanie--------------------------
            if (zapotrzebowanie < 1000)
            {
                return 1000;
            }
            else
            {
                return zapotrzebowanie;
            }
        }


        static public int ObliczZapotrzebowanie(bool plec, DateTime dataUrodzenia, int wzrost, double waga)
        {
            int BMR;
            int wiek = ObliczWiek(dataUrodzenia);

            if (plec)
            {
                BMR = (int)(66 + (13.7 * waga) + (5 * wzrost) - (6.76 * wiek));         //
            }                                                                           //
            else                                                                        // METODA Harrisa-Benedicta
            {                                                                           //
                BMR = (int)(655 + (9.6 * waga) + (1.85 * wzrost) - (4.7 * wiek));       //
            }

            return (int)(BMR * 1.5);

        }

        static public int ObliczCelBialko(double waga, int celKalorii)
        {
            int bialko = (int)(1.5 * waga);
            if (bialko < celKalorii)
            {
                return bialko;
            }
            else
            {
                return (int)(0.5 * celKalorii);
            }
           
        }

        static public int ObliczCelTluszcze(int celKalorii)
        {
            return celKalorii / 36;    //25% zapotrzebowania z tłuszczu (każdy gram tłuszczu ma 9kcal)
        }

        static public int ObliczCelWegle(int celKalorie, int celBialko, int celTluszcze)
        {
            return (celKalorie - ((celBialko * 4) + (celTluszcze * 9))) / 4;
        }

        static public int ObliczWiek(DateTime dataUrodzenia)
        {
            int age = DateTime.Today.Year - dataUrodzenia.Year;
            if (dataUrodzenia.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }
}
