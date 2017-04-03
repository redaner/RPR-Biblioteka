using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datum.Biblioteka;
using System.Drawing;

namespace RPRZadaca1
{
    [Serializable]
    public class NaucniRad : Knjiga, NaucniInterfejs
    {
        private string konferencija;
        private string oblast_nauke;

        public NaucniRad() { }

        public NaucniRad(string pnaslov_knjige, List<string> pspisak_autora, string pisbn, string pzanr,
                        string pnaziv_izdavaca, int pgodina_izdanja, string pkonferencija, string poblast_nauke) 
                        : base(pnaslov_knjige, pspisak_autora, pisbn, pzanr, pnaziv_izdavaca, pgodina_izdanja)
        {
            konferencija = pkonferencija;
            oblast_nauke = poblast_nauke;
        }

        public string Konferencija
        {
            get
            {
                return konferencija;
            }
            set
            {
                konferencija = value;
            }
        }

        public string Oblast_nauke
        {
            get
            {
                return oblast_nauke;
            }
            set
            {
                oblast_nauke = value;
            }
        }

        public string generalneInformacije()
        {
            return string.Format("Sifra knjige: {0}, Naslov knjige: {1}, ISBN: {2}, Zanr: {3}, Naziv izdavaca: {4}, Godina izdanja: {5}, Konferencija: {6}",
                Sifra_knjige, Naslov_knjige, ISBN, Zanr, Naziv_izdavaca, Godina_izdanja, konferencija);
        }

        public string autoriRada()
        {
            string spisak = "";
            foreach(string s in Spisak_autora)
            {
                spisak += s;
                spisak += "\n";
            }
            return spisak;
        }

        public string oblastRada()
        {
            return oblast_nauke;
        }

        public string oblikReferenciranja()
        {
            return string.Format("{0}, {1}", Naslov_knjige, Godina_izdanja);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
