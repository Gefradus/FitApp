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

            List<Produkt> produkts = Produkty();
            produkts.Add(new Produkt() {
                NazwaProduktu = "Ziemniak", 
                Kalorie = 70, ProduktId = 2,
                Weglowodany = 1, Bialko = 2, Tluszcze = 3 });
            produkts.Add(new Produkt()
            {
                NazwaProduktu = "Banan",
                Kalorie = 70,
                ProduktId = 1,
                Weglowodany = 1,
                Bialko = 2,
                Tluszcze = 3
            });

            path = Environment.CurrentDirectory + "\\produkt.xml";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    new XmlSerializer(typeof(List<Produkt>)).Serialize(fs, produkts);
                }
            }
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
    }
}
