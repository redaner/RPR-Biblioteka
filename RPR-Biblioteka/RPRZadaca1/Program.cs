using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datum.Biblioteka;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.OracleClient;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace RPRZadaca1
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {


            /*Student s1 = new Student("Rasim", "Sabanovic", "0212996174139", Convert.ToDateTime("2/12/1996"), "kom", 17407, "M", "RasimSaban", "sifra", RPRZadaca2.Properties.Resources.almost_famous);
            MasterStudent s2 = new MasterStudent("Meho", "Mehic", "2712016171228", Convert.ToDateTime("27/12/2016"), "", 12345, "G", "MehoMeh", "sifra123", RPRZadaca2.Properties.Resources.almost_famous);
            Profesor p = new Profesor("Suljo", "Suljic", "0203005199105", Convert.ToDateTime("02/03/2005"), "", 11, "M", "Suljex", "12345", RPRZadaca2.Properties.Resources.almost_famous);
            
            //Uposleni u2 = new Uposleni("Daniel", "Day-Lewis", "0402985185108", Convert.ToDateTime("04/02/1985"), "", "DDLewis", "ThereWillBeBlood", RPRZadaca2.Properties.Resources.almost_famous);

            List<string> autori = new List<string>();
            List<string> umjetnici = new List<string>();

            autori.Add("Christiane F.");

            umjetnici.Add("Franco Donatelli");
            umjetnici.Add("Francesco Gamba");

            Knjiga k1 = new Knjiga("Bahnhof ZOO", autori, "ISBN 978-80-85-954-074", "Drama", "NYTimes", 1996);


            autori.Clear();
            autori.Add("Sergio Bonelli");
            autori.Add("Gallieno Ferri");

            Strip st1 = new Strip("Zagor", autori, "ISBN 12-3451-2345", "Akcija", "Editore", 1961, "Kuca strave", umjetnici, 123, true);

            autori.Clear();
            autori.Add("Autor1");
            autori.Add("Autor2");
            autori.Add("Autor3");

            NaucniRad n = new NaucniRad("Inzenjerska Fizika 1", autori, "ISBN 12121-21-212", "Nauka", "ETF Sarajevo", 2013, "Comic Con", "Fizika");

            

            bib.RegistrujClana(s1);
            bib.RegistrujClana(s2);
            bib.RegistrujClana(p);
            //bib.RegistrujUposlenog(u2);
            bib.RegistrujKnjigu(k1);
            bib.RegistrujKnjigu(st1);
            bib.RegistrujKnjigu(n);
            //bib.IznajmiKnjiguUposlenom("ISBN 12121-21-212", 3);*/

       

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pocetni(new Biblioteka("ETT")));
            /* Biblioteka b = new Biblioteka("ETF");     
             for (;;)
             {
                 Console.WriteLine("Dobro došli u ETF biblioteku! Odaberite jednu od opcija: \n1. Registruj/Brisi clana \n2. Registruj/Brisi knjigu \n3. Iznajmi/Vrati knjigu \n4. Pretraga \n5. Analiza sadrzaja \n6. Kraj");
                 string s = Console.ReadLine();
                 if (s == "1")
                 {
                     Console.WriteLine("R za registrovanje, B za brisanje: ");
                     string unos = Console.ReadLine();
                     if (unos == "R")
                     {
                         Console.WriteLine("C za obicnog clana, S za studenta, M za master studenta, P za profesora");
                         string val = Console.ReadLine();
                         if (val != "C" && val != "S" && val != "M" && val != "P")
                         {
                             Console.WriteLine("Nevalidan unos.");
                             continue;
                         }
                         string ime, prezime, jmbg, komentar, dat, metoda;
                         Console.WriteLine("Ime: ");
                         ime = Console.ReadLine();
                         Console.WriteLine("Prezime: ");
                         prezime = Console.ReadLine();
                         Console.WriteLine("Maticni broj: ");
                         jmbg = Console.ReadLine();
                         Console.WriteLine("Datum rodjenja: (Format D/M/G) ");
                         dat = Console.ReadLine();
                         var datum = dat.Split('/');
                         int d = Int32.Parse(datum[0]);
                         int m = Int32.Parse(datum[1]);
                         int g = Int32.Parse(datum[2]);
                         Datum.Biblioteka.Datum konacni_datum = new Datum.Biblioteka.Datum(d, m, g);
                         Console.WriteLine("Komentar: ");
                         komentar = Console.ReadLine();
                         Console.WriteLine("Metoda placanja: (M za mjesecno, G za godisnje) ");
                         metoda = Console.ReadLine();
                         if (val == "C")
                         {
                             try
                             {
                                 b.RegistrujClana(new Clan(ime, prezime, jmbg, konacni_datum, komentar, metoda));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "S")
                         {
                             Console.WriteLine("Broj indeksa: ");
                             string br = Console.ReadLine();
                             int broj = Int32.Parse(br);
                             try
                             {
                                 b.RegistrujClana(new Student(ime, prezime, jmbg, konacni_datum, komentar, broj, metoda));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "M")
                         {
                             Console.WriteLine("Broj indeksa: ");
                             string br = Console.ReadLine();
                             int broj = Int32.Parse(br);
                             try
                             {
                                 b.RegistrujClana(new MasterStudent(ime, prezime, jmbg, konacni_datum, komentar, broj, metoda));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "P")
                         {
                             Console.WriteLine("Sifra zaposlenog: ");
                             string br = Console.ReadLine();
                             int broj = Int32.Parse(br);
                             try
                             {
                                 b.RegistrujClana(new Profesor(ime, prezime, jmbg, konacni_datum, komentar, broj, metoda));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else Console.WriteLine("Pogresan unos.");

                     }
                     else if (unos == "B")
                     {
                         Console.WriteLine("Unesite sifru clana kojeg zelite obrisati: ");
                         int sif = Int32.Parse(Console.ReadLine());
                         b.BrisiClana(sif);
                     }
                 }
                 else if (s == "2")
                 {
                     Console.WriteLine("R za registrovanje, B za brisanje: ");
                     string unos = Console.ReadLine();
                     if (unos == "R")
                     {
                         Console.WriteLine("K za obicnu knjigu, S za strip, N za naucni rad: ");
                         string val = Console.ReadLine();
                         if (val != "K" && val != "S" && val != "N")
                         {
                             Console.WriteLine("Nevalidan unos.");
                             continue;
                         }
                         string naslov, id, zanr, izdavac;
                         int broj_autora, godina;
                         Console.WriteLine("Naslov knjige: ");
                         naslov = Console.ReadLine();
                         Console.WriteLine("Broj autora: ");
                         broj_autora = Int32.Parse(Console.ReadLine());
                         string[] autori = new string[broj_autora];
                         Console.WriteLine("Autori: ");
                         for (int i = 0; i < broj_autora; i++)
                         {
                             autori[i] = Console.ReadLine();
                         }
                         Console.WriteLine("ISBN sifra: ");
                         id = Console.ReadLine();
                         Console.WriteLine("Zanr: ");
                         zanr = Console.ReadLine();
                         Console.WriteLine("Naziv izdavaca: ");
                         izdavac = Console.ReadLine();
                         Console.WriteLine("Godina izdanja: ");
                         godina = Int32.Parse(Console.ReadLine());
                         if (val == "K")
                         {
                             try
                             {
                                 b.RegistrujKnjigu(new Knjiga(naslov, autori, id, zanr, izdavac, godina));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "S")
                         {
                             string kuca;
                             bool spec;
                             int broj_umjetnika, broj_izdanja;
                             Console.WriteLine("Ime izdavacke kuce: ");
                             kuca = Console.ReadLine();
                             Console.WriteLine("Broj umjetnika: ");
                             broj_umjetnika = Int32.Parse(Console.ReadLine());
                             string[] umjetnici = new string[broj_umjetnika];
                             Console.WriteLine("Umjetnici: ");
                             for (int i = 0; i < broj_umjetnika; i++)
                                 umjetnici[i] = Console.ReadLine();
                             Console.WriteLine("Broj izdanja stripa: ");
                             broj_izdanja = Int32.Parse(Console.ReadLine());
                             Console.WriteLine("Da li je specijalno izdanje: (1 za DA, 0 za NE)");
                             int pom = Int32.Parse(Console.ReadLine());
                             if (pom == 0) spec = false;
                             else if (pom == 1) spec = true;
                             else
                             {
                                 Console.WriteLine("Nevalidan unos.");
                                 continue;
                             }
                             try
                             {
                                 b.RegistrujKnjigu(new Strip(naslov, autori, id, zanr, izdavac, godina, kuca, umjetnici, broj_izdanja, spec));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "N")
                         {
                             Console.WriteLine("Unesite konferenciju: ");
                             string konf = Console.ReadLine();
                             Console.WriteLine("Unesite oblast nauke: ");
                             string obl = Console.ReadLine();
                             try
                             {
                                 b.RegistrujKnjigu(new RPRZadaca1.NaucniRad(naslov, autori, id, zanr, izdavac, godina, konf, obl));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }                 
                     }
                     else if (unos == "B")
                     {
                         Console.WriteLine("Unesite sifru knjige koju zelite obrisati: ");
                         int sif = Int32.Parse(Console.ReadLine());
                         b.BrisiKnjigu(sif);
                     }
                 }
                 else if (s == "3")
                 {
                     Console.WriteLine("I za iznajmiti, V za vratiti: ");
                     string unos = Console.ReadLine();
                     if (unos == "I")
                     {
                         Console.WriteLine("Unesite sifru osobe koja zeli iznajmiti knjigu: ");
                         string sifra = Console.ReadLine();
                         Console.WriteLine("Unesite sifru knjige koju zeli iznajmiti: ");
                         int sifra2 = Int32.Parse(Console.ReadLine());
                         b.IznajmiKnjigu(sifra, sifra2);
                     }
                     else if (unos == "V")
                     {
                         Console.WriteLine("Unesite sifru knjige koju zelite vratiti: ");
                         int sifra = Int32.Parse(Console.ReadLine());
                         try
                         {
                             b.VratiKnjigu(sifra);
                         }
                         catch (Exception e)
                         {
                             Console.WriteLine(e.Message);
                         }
                     }
                 }
                 else if (s == "4")
                 {
                     Console.WriteLine("C za pretragu clanova, K za pretragu knjiga: ");
                     string unos = Console.ReadLine();
                     if (unos == "C")
                     {
                         Console.WriteLine("S za pretragu po sifri, N za pretragu po nazivu: ");
                         string val = Console.ReadLine();
                         if (val == "S")
                         {
                             Console.WriteLine("Unesite sifru po kojoj zelite pretragu: ");
                             int sifra = Int32.Parse(Console.ReadLine());
                             try
                             {
                                 Console.WriteLine(b.PretraziPoSifri(sifra));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "N")
                         {
                             Console.WriteLine("Unesite naziv po kojem zelite pretragu: ");
                             string naziv = Console.ReadLine();
                             try
                             {
                                 List<Osoba> l = new List<Osoba>(b.PretraziOsobePoNazivu(naziv));
                                 foreach (Osoba o in l)
                                     Console.WriteLine(o.ToString());
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }

                         }
                         else
                         {
                             Console.WriteLine("Nevalidan unos.");
                             continue;
                         }
                     }
                     else if (unos == "K")
                     {
                         Console.WriteLine("S za pretragu po sifri, N za pretragu po nazivu: ");
                         string val = Console.ReadLine();
                         if (val == "S")
                         {
                             Console.WriteLine("Unesite ISBN po kojem zelite pretragu: ");
                             string id = Console.ReadLine();
                             try
                             {
                                 Console.WriteLine(b.PretraziPoISBNu(id));
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }
                         }
                         else if (val == "N")
                         {
                             Console.WriteLine("Unesite naziv po kojem zelite pretragu: ");
                             string naziv = Console.ReadLine();

                             try
                             {
                                 List<Knjiga> l = new List<Knjiga>(b.PretraziKnjigePoNazivu(naziv));
                                 foreach (Knjiga k in l)
                                     Console.WriteLine(k.ToString());
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                             }


                         }
                         else
                         {
                             Console.WriteLine("Nevalidan unos.");
                             continue;
                         }
                     }
                     else
                     {
                         Console.WriteLine("Nevalidan unos.");
                         continue;
                     }
                 }
                 else if (s == "5")
                 {
                     Console.WriteLine("1 za broj clanova rodjenih u datom mjesecu, 2 za strukturu clanova po godistima, 3 za broj knjiga po zanru");
                     string val = Console.ReadLine();
                     if (val == "1")
                     {
                         Console.WriteLine("Unesite mjesec za koji zelite informacije: (brojcana vrijednost) ");
                         int mj = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("Broj clanova rodjenih u {0}. mjesecu je: {1}\n", mj, b.BrojClanovaPoMjesecuRodjenja(mj));
                     }
                     else if (val == "2")
                     {
                         Console.WriteLine(b.StrukturaCitaocaPoGodistima());
                     }
                     else if (val == "3")
                     {
                         Console.WriteLine(b.BrojKnjigaPoZanrovima());
                     }
                     else
                     {
                         Console.WriteLine("Nevalidan unos.");
                         continue;
                     }
                 }
                 else if (s == "6")
                 {
                     return;
                 }
             }*/
        }
    }
}
