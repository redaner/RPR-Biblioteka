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
    public class Strip : Knjiga
    {
        private string ime_kuce;
        private List<string> spisak_umjetnika;
        private int broj_izdanja;
        private bool specijalno;

        public Strip() { }

        public Strip(string pnaslov_knjige, List<string> pspisak_autora, string pisbn, 
                    string pzanr, string pnaziv_izdavaca, int pgodina_izdanja, string pime_kuce, List<string> pspisak_umjetnika,
                    int pbroj_izdanja, bool pspecijalno)
                    : base(pnaslov_knjige, pspisak_autora, pisbn,
                    pzanr, pnaziv_izdavaca, pgodina_izdanja)
        {
            ime_kuce = pime_kuce;
            spisak_umjetnika = pspisak_umjetnika;
            broj_izdanja = pbroj_izdanja;
            specijalno = pspecijalno;
        }

        public string Ime_kuce
        {
            get
            {
                return ime_kuce;
            }
            set
            {
                ime_kuce = value;
            }
        }

        public List<string> Spisak_umjetnika
        {
            get
            {
                return spisak_umjetnika;
            }
            set
            {
                spisak_umjetnika = value;
            }
        }

        public int Broj_izdanja
        {
            get
            {
                return broj_izdanja;
            }
            set
            {
                broj_izdanja = value;
            }
        }

        public bool Specijalno
        {
            get
            {
                return specijalno;
            }
            set
            {
                specijalno = value;
            }
        }

        public override string ToString()
        {
            
            return base.ToString();
        }
    }


}
