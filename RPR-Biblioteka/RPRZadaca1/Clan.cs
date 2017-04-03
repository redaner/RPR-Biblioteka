using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPRZadaca1
{
    [Serializable]
    public class Clan : Osoba
    {
        Image slika;
        List<int> lista_zelja;
        private metoda_placanja metod;
        private double popust = 0;
        private bool clanstvo;

        public Clan() { }

        public List<int> Lista_zelja
        {
            get
            {
                return lista_zelja;
            }

            set
            {
                lista_zelja = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }

        public metoda_placanja Metod
        {
            get
            {
                return metod;
            }

            set
            {
                metod = value;
            }
        }

        public double Popust
        {
            get
            {
                return popust;
            }

            set
            {
                popust = value;
            }
        }

        public bool Clanstvo
        {
            get
            {
                return clanstvo;
            }

            set
            {
                clanstvo = value;
            }
        }

        public Clan(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string m, string korisnicko, string lozinka, Image sl)
                : base(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, korisnicko, lozinka)
        {
            
            if (m == "M") Metod = metoda_placanja.mjesecno;
            else if (m == "G") Metod = metoda_placanja.godisnje;
            Lista_zelja = new List<int>();
            Slika = sl;
        }

        public override void DodajKnjigu(Knjiga k)
        {
            base.DodajKnjigu(k);
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public void dodajNaListuZelja(Knjiga k)
        {
            Lista_zelja.Add(k.Sifra_knjige);
        }

       /* public Dictionary<string, int> brojKnjigaPoZanrovima()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            foreach (Knjiga k in Iznajmljene_knjige)
            {
                if (d.ContainsKey(k.Zanr))
                    d[k.Zanr]++;
                else
                    d.Add(k.Zanr, 1);
            }
            return d;
        }*/

        /*public Dictionary<int, int> brojKnjigaPoStoljecima()
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (Knjiga k in Iznajmljene_knjige)
            {
                if (d.ContainsKey(k.Godina_izdanja % 100 + 1))
                    d[k.Godina_izdanja / 100 + 1]++;
                else
                    d.Add(k.Godina_izdanja / 100 + 1, 1); 
            }
            return d;
        }*/

        public void azuriraj(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string m, string korisnicko, string lozinka, Image sl)
        {
            if (m == "M") Metod = metoda_placanja.mjesecno;
            else if (m == "G") Metod = metoda_placanja.godisnje;
            Slika = sl;
            Ime = pime;
            Prezime = pprezime;
            Datum_rodjenja = pdatum_rodjenja;
            if (validacija(pmaticni_broj))
                Maticni_broj = pmaticni_broj;
            else throw new ArgumentException("Maticni broj nije validan. ");
            Username = korisnicko;
            Password = lozinka;
        }
    }
}
