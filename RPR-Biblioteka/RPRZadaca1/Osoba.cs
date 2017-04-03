using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datum.Biblioteka;
using System.Drawing;
using System.Security.Cryptography;

namespace RPRZadaca1
{
    [Serializable]
    public abstract class Osoba
    {
        private int sifra;
        private string ime;
        private string prezime;
        private string username;
        private string password;
        protected static int za_sifru { get; set; }
        private string maticni_broj;
        private DateTime datum_rodjenja;
        private string komentar;
        private List<int> iznajmljene_knjige;
        
        public Osoba() { }

        public string getMd5Hash(string pass)
        {
            
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(pass));

            
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public bool verifyMd5Hash(string pass)
        {
            string hashPass = getMd5Hash(pass);
            string hash = password;
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashPass, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checksum(string jmbg)
        {
            int[] niz_cifri = new int[13];

            for (int i = 0; i < jmbg.Length; i++)
                niz_cifri[i] = jmbg[i] - '0';


            int broj = 11 - ((7 * (niz_cifri[0] + niz_cifri[6]) + 6 * (niz_cifri[1] + niz_cifri[7]) + 5 * (niz_cifri[2] + niz_cifri[8]) + 4 * (niz_cifri[3] + niz_cifri[9])
                + 3 * (niz_cifri[4] + niz_cifri[10]) + 2 * (niz_cifri[5] + niz_cifri[11])) % 11);
            return broj == niz_cifri[12];
        }

        public bool validacija(string jmbg)
        {

            string[] podstringovi = new string[3];
            podstringovi[0] = jmbg.Substring(0, 2);
            podstringovi[1] = jmbg.Substring(2, 2);
            podstringovi[2] = jmbg.Substring(4, 3);
            int dd = Int32.Parse(podstringovi[0]);
            int mm = Int32.Parse(podstringovi[1]);
            int yy = Int32.Parse(podstringovi[2]);
            if (yy % 1000 != datum_rodjenja.Year % 1000 || dd != datum_rodjenja.Day || mm != datum_rodjenja.Month) return false;

            int[] niz_cifri = new int[13];

            for (int i = 0; i < jmbg.Length; i++)
                niz_cifri[i] = jmbg[i] - '0';


            int broj = 11 - ((7 * (niz_cifri[0] + niz_cifri[6]) + 6 * (niz_cifri[1] + niz_cifri[7]) + 5 * (niz_cifri[2] + niz_cifri[8]) + 4 * (niz_cifri[3] + niz_cifri[9])
                + 3 * (niz_cifri[4] + niz_cifri[10]) + 2 * (niz_cifri[5] + niz_cifri[11])) % 11);
            return broj == niz_cifri[12];
        }

        public Osoba(string pime, string pprezime, string pmaticni_broj, DateTime pdatum_rodjenja, string pkomentar, string korisnicko, string lozinka)
        {
            ime = pime;
            prezime = pprezime;
            datum_rodjenja = pdatum_rodjenja;
            if (validacija(pmaticni_broj))
                maticni_broj = pmaticni_broj;
            else throw new ArgumentException("Maticni broj nije validan. ");
            komentar = pkomentar;
            Iznajmljene_knjige = new List<int>();
            sifra = za_sifru;
            za_sifru++;
            Username = korisnicko;
            Password = getMd5Hash(lozinka);
        }

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }

        public int Sifra
        {
            get
            {
                return sifra;
            }
            set
            {
                sifra = value;
            }
        }

        public string Maticni_broj
        {
            get
            {
                return maticni_broj;
            }
            set
            {
                maticni_broj = value;
            }
        }

        public DateTime Datum_rodjenja
        {
            get
            {
                return datum_rodjenja;
            }
            set
            {
                datum_rodjenja = value;
            }
        }

        public string Komentar
        {
            get
            {
                return komentar;
            }
            set
            {
                komentar = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public List<int> Iznajmljene_knjige
        {
            get
            {
                return iznajmljene_knjige;
            }

            set
            {
                iznajmljene_knjige = value;
            }
        }

        public virtual void DodajKnjigu(Knjiga k)
        {
            Iznajmljene_knjige.Add(k.Sifra_knjige);
        }

        public virtual void IzbaciKnjigu(Knjiga k)
        {
            Iznajmljene_knjige.RemoveAll(x => x== k.Sifra_knjige);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", ime, prezime);
        }

    }
}
