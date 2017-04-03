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
    public class MasterStudent : Clan
    {
        private int broj_indeksa;
        
        public MasterStudent() {  }

        public MasterStudent(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, int pbroj_indeksa, string m, string korisnicko, string lozinka, Image sl) :
            base(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, m, korisnicko, lozinka, sl)
        {
            broj_indeksa = pbroj_indeksa;
            Popust = 0.125;
            if (m == "M")
                Metod = metoda_placanja.mjesecno;
            else if (m == "G")
                Metod = metoda_placanja.godisnje;
            Clanstvo = true;
        }

        public int Broj_indeksa
        {
            get
            {
                return broj_indeksa;
            }
            set
            {
                broj_indeksa = value;
            }
        }

       

        public override void DodajKnjigu(Knjiga k)
        {
            base.DodajKnjigu(k);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void azuriraj(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string m, int br, string korisnicko, string lozinka, Image sl)
        {
            base.azuriraj(pime, pprezime, pmaticni_broj, pdatum_rodjenja, pkomentar, m, korisnicko, lozinka, sl);
            Broj_indeksa = br;
        }
    }
}

