using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datum.Biblioteka;
using System.Drawing;

namespace RPRZadaca1
{
    public enum metoda_placanja { mjesecno, godisnje };
    public class Biblioteka
    {
      
        private static int mjesecna_clanarina = 20;
        private static int godisnja_clanarina = 200;
        private List<Clan> clanovi;
        private List<Knjiga> knjige;
        private List<Uposleni> uposlenici;
        private int broj_knjiga;
        private double balans;
        private string ime_biblioteke;

        public bool slobodanUsername(string user)
        {
            for (int i = 0; i < clanovi.Count; i++)
            {
                if (user == clanovi[i].Username) return false;
            }
            for (int i = 0; i < Uposlenici.Count; i++)
            {
                if (user == Uposlenici[i].Username) return false;
            }
            return true;
        }

        public Biblioteka() { }

        public Biblioteka(string ime)
        {
            Clanovi = new List<Clan>();
            Knjige = new List<Knjiga>();
            Uposlenici = new List<Uposleni>();
            broj_knjiga = 0;
            balans = 0;
            ime_biblioteke = ime;
        }

        public double Balans
        {
            get
            {
                return balans;
            }
        }

        public int Broj_knjiga
        {
            get
            {
                return broj_knjiga;
            }
        }

        public List<Knjiga> Knjige
        {
            get
            {
                return knjige;
            }

            set
            {
                knjige = value;
            }
        }

        public List<Clan> Clanovi
        {
            get
            {
                return clanovi;
            }

            set
            {
                clanovi = value;
            }
        }

        public List<Uposleni> Uposlenici
        {
            get
            {
                return uposlenici;
            }

            set
            {
                uposlenici = value;
            }
        }

        public void RegistrujKnjigu(Knjiga k)
        {
            foreach (Knjiga k1 in Knjige)
                if (k.ISBN == k1.ISBN)
                {
                    throw new Exception("Poklapanje ISBN-a.");
                }
            k.Sifra_knjige = Knjige.Count;
            Knjige.Add(k);
            broj_knjiga++;
        }

        public Dictionary<Knjiga, int> clanVracanjeKnjiga(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
                Console.WriteLine("Izn: " + l[i]);
            Dictionary<Knjiga, int> d = new Dictionary<Knjiga, int>();
            foreach (int sif in l)
            {
                foreach (Knjiga k in Knjige)
                {
                    Console.WriteLine(sif + " " + k.Sifra_knjige);
                    if (sif == k.Sifra_knjige)
                    {
                        d.Add(k, k.Vrijeme);
                    }
                }
            }

            return d;
        } 

        public List<Knjiga> uposleniIznajmljene(List<int> l)
        {
            List<Knjiga> lista = new List<Knjiga>();
            foreach (int x in l)
            {
                foreach (Knjiga k in Knjige)
                {
                    if (x == k.Sifra_knjige)
                    {
                        lista.Add(k);
                    }
                }
            }
            return lista;
        }

        public Dictionary<string, int> clanBrojKnjigaPoZanrovima(List<int> l)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            foreach (int k in l)
            {
                if (d.ContainsKey(vratiKnjiguSaSifrom(k).Zanr))
                    d[vratiKnjiguSaSifrom(k).Zanr]++;
                else
                    d.Add(vratiKnjiguSaSifrom(k).Zanr, 1);
            }
            return d;
        }

        public Dictionary<int, int> clanBrojKnjigaPoStoljecima(List<int> l)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int k in l)
            {
                if (d.ContainsKey(vratiKnjiguSaSifrom(k).Godina_izdanja / 100 + 1))
                    d[vratiKnjiguSaSifrom(k).Godina_izdanja / 100 + 1]++;
                else
                    d.Add(vratiKnjiguSaSifrom(k).Godina_izdanja / 100 + 1, 1);
            }
            return d;
        }


        public Knjiga vratiKnjiguSaSifrom(int sif)
        {
            foreach (Knjiga k in Knjige)
            {
                if (k.Sifra_knjige == sif)
                    return k;
            }
            throw new Exception("Nije pronadjena knjiga.");

        }

        public void BrisiKnjigu(int id)
        {
            if (vratiKnjiguSaSifrom(id).Iznajmljena)
            {
                foreach (Clan c in Clanovi)
                {
                    if (c.Iznajmljene_knjige.Contains(id))
                    {
                        c.Iznajmljene_knjige.Remove(id);
                    }
                    if (c.Lista_zelja.Contains(id))
                    {
                        c.Lista_zelja.Remove(id);
                    }
                }
                foreach (Uposleni u in Uposlenici)
                {
                    if (u.Iznajmljene_knjige.Contains(id))
                    {
                        u.Iznajmljene_knjige.Remove(id);
                    }
                }
            }
            int vel = Knjige.Count;
            Knjige.RemoveAll(x => x.Sifra_knjige == id);
            if (vel == Knjige.Count)
            {
                throw new Exception("Nije pronadjena knjiga.");
            }

            broj_knjiga--;
        }

        public void RegistrujClana(Clan o)
        {
            
            List<int> lista_sifri = new List<int>();
            foreach (Clan c in Clanovi)
                lista_sifri.Add(c.Sifra);
            foreach (Uposleni u in Uposlenici)
                lista_sifri.Add(u.Sifra);
            o.Sifra = lista_sifri.Max() + 1;
            Clanovi.Add(o);
            if (o.Metod == metoda_placanja.godisnje)
                balans += godisnja_clanarina - godisnja_clanarina * o.Popust;
            else if (o.Metod == metoda_placanja.mjesecno)
                balans += mjesecna_clanarina - mjesecna_clanarina * o.Popust;
            o.Clanstvo = true;
        }

        public void RegistrujUposlenog(Uposleni u)
        {
            List<int> lista_sifri = new List<int>();
            foreach (Clan c in Clanovi)
                lista_sifri.Add(c.Sifra);
            foreach (Uposleni up in Uposlenici)
                lista_sifri.Add(up.Sifra);
            u.Sifra = lista_sifri.Max() + 1;
            
            Uposlenici.Add(u);
        }

        public Clan vratiClanaSaSifrom(int sifra)
        {
            
            foreach (Clan c in Clanovi)
            {
                
                if (c.Sifra == sifra)
                {
                    return c;
                }
            }
            throw new Exception("Nije pronadjen clan.");
        }

        public Uposleni vratiUposlenogSaSifrom(int sif)
        {
            foreach (Uposleni c in Uposlenici)
            {

                if (c.Sifra == sif)
                {
                    return c;
                }
            }
            throw new Exception("Nije pronadjen uposleni.");
        }

        public void BrisiUposlenog(int sifra)
        {
            foreach (int k in vratiUposlenogSaSifrom(sifra).Iznajmljene_knjige)
            {
                foreach (Knjiga k2 in Knjige)
                {
                    if (k == k2.Sifra_knjige)
                    {
                        k2.Iznajmljena = false;
                    }
                }
            }
            int vel = Uposlenici.Count;
            Uposlenici.RemoveAll(x => x.Sifra == sifra);
            if (vel == Uposlenici.Count) throw new Exception("Nije pronadjen uposleni.");
        }

        public void BrisiClana(int sifra)
        {
            foreach (int k in vratiClanaSaSifrom(sifra).Iznajmljene_knjige)
            {
                foreach (Knjiga k2 in Knjige)
                {
                    if (k == k2.Sifra_knjige)
                    {
                        k2.Iznajmljena = false;
                    }
                }
            }
            int vel = Clanovi.Count;
            Clanovi.RemoveAll(x => x.Sifra == sifra);
            if (vel == Clanovi.Count) throw new Exception("Nije pronadjena osoba.");
        }

        public void IznajmiKnjiguClanu(int sifra, int id)
        {
            for (int i = 0; i < Clanovi.Count; i++)
            {
                if (Clanovi[i].Sifra == sifra)
                {
                    if (Clanovi[i].Clanstvo == false)
                    {
                        throw new Exception("Suspendovan clan.");

                    }
                    for (int j = 0; j < Knjige.Count; j++)
                    {
                        if (Knjige[j].Sifra_knjige == id)
                        {
                            if (Knjige[j].Iznajmljena == true)
                            {
                                throw new Exception("Knjiga vec iznajmljena.");

                            }
                            Knjige[j].Iznajmio = Clanovi[i].Sifra;
                            Knjige[j].Iznajmljena = true;
                            Clanovi[i].DodajKnjigu(Knjige[j]);
                            return;
                        }
                        if (j == Knjige.Count - 1)
                        {
                            throw new Exception("Knjiga nije pronadjena.");
                        }
                    }
                }
                if (i == Clanovi.Count - 1)
                {
                    throw new Exception("Clan nije pronadjen.");

                }
            }
            throw new Exception("Prazna biblioteka.");
        }

        public void IznajmiKnjiguUposlenom(int sifra, int id)
        {
            for (int i = 0; i < Uposlenici.Count; i++)
            {
                if (Uposlenici[i].Sifra == sifra)
                {
                    
                    for (int j = 0; j < Knjige.Count; j++)
                    {
                        if (Knjige[j].Sifra_knjige == id)
                        {
                            if (Knjige[j].Iznajmljena == true)
                            {
                                throw new Exception("Knjiga vec iznajmljena.");

                            }
                            Knjige[j].Iznajmio = Uposlenici[i].Sifra;
                            Knjige[j].Iznajmljena = true;
                            Uposlenici[i].DodajKnjigu(Knjige[j]);
                            return;
                        }
                        if (j == Knjige.Count - 1)
                        {
                            throw new Exception("Knjiga nije pronadjena.");
                        }
                    }
                }
                if (i == Uposlenici.Count - 1)
                {
                    throw new Exception("Clan nije pronadjen.");

                }
            }
            throw new Exception("Prazna biblioteka.");
        }

        public void VratiKnjigu(int sifra)
        {
            Console.WriteLine(sifra);
            int i;
            for (i = 0; i < Knjige.Count; i++)
            {
                if (Knjige[i].Sifra_knjige == sifra)
                {
                    if (Knjige[i].Iznajmljena == false)
                    {
                        throw new Exception("Knjiga nije iznajmljena.");

                    }
                    Knjige[i].Iznajmljena = false;
                    for (int j = 0; j < Clanovi.Count; j++)
                    {
                        if (Clanovi[j].Sifra == Knjige[i].Iznajmio)
                        {
                            Clanovi[j].IzbaciKnjigu(Knjige[i]);
                            return;
                        }
                    }
                    for (int j = 0; j < Uposlenici.Count; j++)
                    {
                        if (Uposlenici[j].Sifra == Knjige[i].Iznajmio)
                        {
                            Clanovi[j].IzbaciKnjigu(Knjige[i]);
                            return;
                        }
                    }
                }
            }
            if (i == Knjige.Count)
            {
                throw new Exception("Ne mozete vratiti knjigu koja nije bila tu prije.");
            }
            broj_knjiga++;
        }

        public Knjiga PretraziPoISBNu(string id)
        {
            foreach (Knjiga k1 in Knjige)
                if (k1.ISBN == id)
                {
                    return k1;
                }
            throw new Exception("Nije nadjena knjiga!");
        }

        public Osoba PretraziPoSifri(int sifra)
        {
            foreach (Osoba o in Clanovi)
                if (o.Sifra == sifra)
                    return o;
            throw new Exception("Nije nadjen clan!");
        }

        public Uposleni PretraziUposlenePoSifri(int sifra)
        {
            foreach (Uposleni o in Uposlenici)
                if (o.Sifra == sifra)
                    return o;
            throw new Exception("Nije nadjen uposlenik!");
        }

        public List<Knjiga> PretraziKnjigePoNazivu(string naziv)
        {
            List<Knjiga> l = new List<Knjiga>();
            foreach (Knjiga k in Knjige)
            {
                if (k.Naslov_knjige.Contains(naziv) || k.Naziv_izdavaca.Contains(naziv) || k.Zanr.Contains(naziv))
                    l.Add(k);
                for (int i = 0; i < k.Spisak_autora.Count(); i++)
                    if (k.Spisak_autora[i].Contains(naziv))
                    {
                        if (!l.Contains(k))
                            l.Add(k);
                    }
            }
            return l;
        }

        public Osoba nadjiUsername(string user)
        {
            foreach (Osoba o in Clanovi)
                if (o.Username == user) return o;
            foreach (Uposleni u in Uposlenici)
                if (u.Username == user) return u;

            throw new Exception("Nije pronadjena username.");
        }

        public List<Osoba> PretraziOsobePoNazivu(string naziv)
        {
            List<Osoba> l = new List<Osoba>();
            foreach (Osoba o in Clanovi)
            {
                if ((o.Ime + o.Prezime).Contains(naziv) || o.Username.Contains(naziv) || o.Komentar.Contains(naziv))
                    l.Add(o);
            }
            return l;
        }

        public List<Uposleni> PretraziUposlenePoNazivu(string naziv)
        {
            List<Uposleni> l = new List<Uposleni>();
            foreach (Uposleni o in Uposlenici)
            {
                if ((o.Ime + o.Prezime).Contains(naziv) || o.Username.Contains(naziv) || o.Komentar.Contains(naziv))
                    l.Add(o);
            }
            return l;
        }

        public int BrojClanovaPoMjesecuRodjenja(int mjesec)
        {
            int konacni_broj = 0;
            foreach (Osoba o in Clanovi)
            {
                if (o.Datum_rodjenja.Month == mjesec)
                    konacni_broj++;
            }
            return konacni_broj;
        }

        public SortedDictionary<int, int> StrukturaCitaocaPoGodistima()
        {
            SortedDictionary<int, int> d = new SortedDictionary<int, int>();
            foreach (Osoba o in Clanovi)
            {
                if (d.ContainsKey(o.Datum_rodjenja.Year))
                    d[o.Datum_rodjenja.Year]++;
                else
                    d.Add(o.Datum_rodjenja.Year, 1);
            }
           

            return d;
        }

        public Dictionary<string, int> BrojKnjigaPoZanrovima()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            foreach (Knjiga k in Knjige)
            {
                if (d.ContainsKey(k.Zanr))
                    d[k.Zanr]++;
                else
                    d.Add(k.Zanr, 1);
            }
            return d;
        }


    }

    
}
