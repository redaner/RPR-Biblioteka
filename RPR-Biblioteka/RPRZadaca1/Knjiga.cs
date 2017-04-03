using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datum.Biblioteka;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;

namespace RPRZadaca1
{   
    [Serializable]
    public partial class Knjiga
    {
        private int sifra_knjige;
        private string naslov_knjige;
        private List<string> spisak_autora;
        private string isbn;
        private string zanr;
        private string naziv_izdavaca;
        private int godina_izdanja;
        private bool iznajmljena;
        private int iznajmio;
        private static int za_sifru = 0;
        private int vrijeme;
        private bool validacija(string id)
        {
            if (id.Length != 17 && id.Length != 22) return false;
            if (id.Substring(0, 4) != "ISBN") return false;

            return true;
        }


        public Knjiga(string pnaslov_knjige, List<string> pspisak_autora, string pisbn, string pzanr,
            string pnaziv_izdavaca, int pgodina_izdanja)
        {
            naslov_knjige = pnaslov_knjige;
            spisak_autora = pspisak_autora;
            if (validacija(pisbn))
                isbn = pisbn;
            else
                throw new Exception("Nevalidan ISBN.");
            zanr = pzanr;
            naziv_izdavaca = pnaziv_izdavaca;
            godina_izdanja = pgodina_izdanja;
            iznajmljena = false;
            sifra_knjige = za_sifru;
            za_sifru++;
            Vrijeme = 14;
        }

        public Knjiga() { }

        public int Sifra_knjige
        {
            get
            {
                return sifra_knjige;
            }
            set
            {
                sifra_knjige = value;
            }
        }

        public string Naslov_knjige
        {
            get
            {
                return naslov_knjige;
            }
            set
            {
                naslov_knjige = value;
            }
        }

        public List<string> Spisak_autora
        {
            get
            {
                return spisak_autora;
            }
            set
            {
                spisak_autora = value;
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public string Zanr
        {
            get
            {
                return zanr;
            }
            set
            {
                zanr = value;
            }
        }

        public string Naziv_izdavaca
        {
            get
            {
                return naziv_izdavaca;
            }
            set
            {
                naziv_izdavaca = value;
            }
        }

        public int Godina_izdanja
        {
            get
            {
                return godina_izdanja;
            }
            set
            {
                godina_izdanja = value;
            }
        }

        public bool Iznajmljena
        {
            get
            {
                return iznajmljena;
            }
            set
            {
                iznajmljena = value;
            }
        }

        public int Vrijeme
        {
            get
            {
                return vrijeme;
            }

            set
            {
                vrijeme = value;
            }
        }

        

   

        public int Iznajmio
        {
            get
            {
                return iznajmio;
            }

            set
            {
                iznajmio = value;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (string s1 in spisak_autora)
            {
                s += s1;
                s += " ";
            }
            return string.Format("{0}", naslov_knjige);
        }

        public void azuriraj(string pnaslov_knjige, List<string> pspisak_autora, string pisbn, string pzanr,
            string pnaziv_izdavaca, int pgodina_izdanja)
        {
            Naslov_knjige = pnaslov_knjige;
            Spisak_autora = pspisak_autora;
            ISBN = pisbn;
            Zanr = pzanr;
            Naziv_izdavaca = pnaziv_izdavaca;
            Godina_izdanja = pgodina_izdanja;
        }
    }
}
