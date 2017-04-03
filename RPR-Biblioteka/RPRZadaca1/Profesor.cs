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
    public sealed class Profesor : Clan
    {
        private int sifra_zaposlenog;
        
        public Profesor() { }

        public Profesor(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, int psifra_zaposlenog, string m, string korisnicko, string lozinka, Image sl) :
            base(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, m, korisnicko, lozinka, sl)
        {
            sifra_zaposlenog = psifra_zaposlenog;
            if (m == "M")
                Metod = metoda_placanja.mjesecno;
            else if (m == "G")
                Metod = metoda_placanja.godisnje;
            Popust = 0.15;
            Clanstvo = true;
        }

        public int Sifra_zaposlenog
        {
            get
            {
                return sifra_zaposlenog;
            }
            set
            {
                sifra_zaposlenog = value;
            }
        }

        

        public void azuriraj(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string m, int br, string korisnicko, string lozinka, Image sl)
        {
            base.azuriraj(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, m, korisnicko, lozinka, sl);
            Sifra_zaposlenog = br;
        }
    }
}

