using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FitApp
{
    public class ModelXML
    {
        public void CreateXMLIfNotExists()
        {
            string path = Environment.CurrentDirectory + "\\klient.xml";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    new XmlSerializer(typeof(List<Klient>)).Serialize(fs, new List<Klient>());
                }
            }

            path = Environment.CurrentDirectory + "\\dzien.xml";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    new XmlSerializer(typeof(List<Dzien>)).Serialize(fs, new List<Dzien>());
                }
            }

            path = Environment.CurrentDirectory + "\\posilek.xml";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    new XmlSerializer(typeof(List<Posilek>)).Serialize(fs, new List<Posilek>());
                }
            }


            path = Environment.CurrentDirectory + "\\produkt.xml";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    new XmlSerializer(typeof(List<Produkt>)).Serialize(fs, new List<Produkt>());
                }
            }
        }

        public void ZapiszKlientow(List<Klient> klienci)
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\klient.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(List<Klient>)).Serialize(fs, klienci);
            }
        }

        public void ZapiszDni(List<Dzien> dni)
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\dzien.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(List<Dzien>)).Serialize(fs, dni);
            }
        }

        public void ZapiszPosilki(List<Posilek> posilki)
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\posilek.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(List<Posilek>)).Serialize(fs, posilki);
            }
        }

        public void ZapiszProdukty(List<Produkt> produkty)
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\produkt.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(List<Produkt>)).Serialize(fs, produkty);
            }
        }

        public Klient DajKlienta(int klientID)
        {
            foreach (var item in Klienci())
            {
                if (item.KlientID == klientID)
                {
                    return item;
                }
            }

            return null;
        }


        public Posilek DajPosilek(int posilekID)
        {
            foreach (var item in Posilki())
            {
                if (item.PosilekId == posilekID)
                {
                    return item;
                }
            }

            return null;
        }

        public Dzien DajDzien(int dzienID)
        {
            foreach (var item in Dni())
            {
                if (item.DzienId == dzienID)
                {
                    return item;
                }
            }
            return null;
        }

        public Produkt DajProdukt(int produktID)
        {
            foreach (var item in Produkty())
            {
                if (item.ProduktId == produktID)
                {
                    return item;
                }
            }
            return null;
        }

        public int AutoIncrementKlientow(List<Klient> listaKlientow)
        {
            int aktualnyID = 1;
            foreach (var item in listaKlientow)
            {
                if (aktualnyID <= item.KlientID)
                {
                    aktualnyID = item.KlientID + 1;
                }
            }

            return aktualnyID;
        }

        public int AutoIncrementDni(List<Dzien> listaDni)
        {
            int aktualnyID = 1;
            foreach (var item in listaDni)
            {
                if (aktualnyID <= item.DzienId)
                {
                    aktualnyID = item.DzienId + 1;
                }
            }

            return aktualnyID;
        }

        public int AutoIncrementPosilki(List<Posilek> listaPosilkow)
        {
            int aktualnyID = 1;
            foreach (var item in listaPosilkow)
            {
                if (aktualnyID <= item.PosilekId)
                {
                    aktualnyID = item.PosilekId + 1;
                }
            }

            return aktualnyID;
        }

        public int AutoIncrementProdukty(List<Produkt> listaProduktow)
        {
            int aktualnyID = 1;
            foreach (var item in listaProduktow)
            {
                if (aktualnyID <= item.ProduktId)
                {
                    aktualnyID = item.ProduktId + 1;
                }
            }

            return aktualnyID;
        }

        public bool CzyPosilekWDanymDniu(int posilekID, int dzienID)
        {
            foreach (var item in Dni())
            {
                if (item.DzienId == dzienID)
                {
                    if (DajPosilek(posilekID).DzienId == item.DzienId)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public List<Produkt> Produkty()
        {
            List<Produkt> produkty = new List<Produkt>();
            XmlSerializer produktySerial = new XmlSerializer(typeof(List<Produkt>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\produkt.xml", FileMode.Open, FileAccess.Read))
            {
                produkty = produktySerial.Deserialize(fs) as List<Produkt>;
            }

            return produkty;
        }


        public List<Posilek> Posilki()
        {
            List<Posilek> posilki = new List<Posilek>();
            XmlSerializer posilkiSerial = new XmlSerializer(typeof(List<Posilek>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\posilek.xml", FileMode.Open, FileAccess.Read))
            {
                posilki = posilkiSerial.Deserialize(fs) as List<Posilek>;
            }

            return posilki;
        }


        public List<Dzien> Dni()
        {
            List<Dzien> dni = new List<Dzien>();
            XmlSerializer dniSerial = new XmlSerializer(typeof(List<Dzien>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\dzien.xml", FileMode.Open, FileAccess.Read))
            {
                dni = dniSerial.Deserialize(fs) as List<Dzien>;
            }

            return dni;
        }

        public List<Klient> Klienci()
        {
            List<Klient> dni = new List<Klient>();
            XmlSerializer dniSerial = new XmlSerializer(typeof(List<Klient>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\klient.xml", FileMode.Open, FileAccess.Read))
            {
                dni = dniSerial.Deserialize(fs) as List<Klient>;
            }

            return dni;
        }



        public int DajKlientaPoDniuID(int dzienID)
        {
            foreach (var item in Dni())
            {
                if (dzienID == item.DzienId)
                {
                    return item.KlientId;
                }
            }

            return -1;
        }

        public int DajDzisiajID(int klientID)
        {
            foreach (var item in Dni())
            {
                if (item.KlientId == klientID && item.Dzien1 == DateTime.Now.Date)
                {
                    return item.DzienId;
                }
            }

            return -1;
        }

        public bool CzyJestDzisiaj(int klientID)
        {
            foreach (var item in Dni())
            {
                if (item.KlientId == klientID && item.Dzien1 == DateTime.Now.Date)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
