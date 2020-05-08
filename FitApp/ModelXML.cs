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
            string path = Environment.CurrentDirectory + "\\dzien.xml";
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

        public int AutoIncrementDni(List<Dzien> listaDni)
        {
            int i = 0;
            foreach (var item in listaDni)
            {
                i++;
            }

            return i;
        }

        public int AutoIncrementPosilki(List<Posilek> listaPosilkow)
        {
            int i = 0;
            foreach (var item in listaPosilkow)
            {
                i++;
            }

            return i;
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

        public bool CzyJestDzisiaj(List<Dzien> dni)
        {
            foreach (var item in dni)
            {
                if (item.Dzien1.Date == DateTime.Now.Date)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
