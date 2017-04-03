using RPRZadaca1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPRZadaca2
{
    public class BibliotekaBaza
    {
        OracleDataAdapter dataAdapter;
        OracleDataReader dataReader;
        OracleConnection konekcija;
        Biblioteka b;
        DataSet d;

        public OracleDataAdapter DataAdapter
        {
            get
            {
                return dataAdapter;
            }

            set
            {
                dataAdapter = value;
            }
        }

        public OracleDataReader DataReader
        {
            get
            {
                return dataReader;
            }

            set
            {
                dataReader = value;
            }
        }

        public OracleConnection Konekcija
        {
            get
            {
                return konekcija;
            }

            set
            {
                konekcija = value;
            }
        }

        public Biblioteka B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public BibliotekaBaza()
        {
            b = new Biblioteka("ETF");
            konekcija = new OracleConnection();
            dataAdapter = new OracleDataAdapter();

        }

        public void ucitajBazu()
        {
            ucitajClanove();
            ucitajUposlenike();
            ucitajKnjige();
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new OracleConnection();
                konekcija.ConnectionString = @"Data Source=
                (DESCRIPTION =
                        (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                        (CONNECT_DATA =
                        (SERVER = DEDICATED)
                        (SERVICE_NAME = )
    
                        )
                    )
                ;User Id= SYSTEM;Password= milankundera;Persist Security Info=True;";
                konekcija.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int dodajClana(Clan u)
        {
            b.RegistrujClana(u);
            
            OracleCommand cmd = konekcija.CreateCommand();
            string insert = "INSERT into osobe (id, ime, prezime, username, password, jmbg, datum_rod, komentar) ";
            insert += "values (:k_Id, :k_Ime, :k_Prezime, :k_Username, :k_Password, :k_Jmbg, :k_Datum_rod, :k_Komentar)";
            cmd.CommandText = insert;

            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = u.Sifra;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Ime = new OracleParameter();
            k_Ime.Value = u.Ime;
            k_Ime.ParameterName = "k_Ime";

            OracleParameter k_Prezime = new OracleParameter();
            k_Prezime.Value = u.Prezime;
            k_Prezime.ParameterName = "k_Prezime";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = u.Username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = u.Password;
            k_Password.ParameterName = "k_Password";

            OracleParameter k_Jmbg = new OracleParameter();
            k_Jmbg.Value = u.Maticni_broj;
            k_Jmbg.ParameterName = "k_Jmbg";
            OracleParameter k_Datum_rod = new OracleParameter();
            k_Datum_rod.Value = u.Datum_rodjenja;
            k_Datum_rod.ParameterName = "k_Datum_rod";

            OracleParameter k_Komentar = new OracleParameter();
            k_Komentar.Value = u.Komentar;
            k_Komentar.ParameterName = "k_Komentar";

            cmd.Parameters.Add(k_Id);
            cmd.Parameters.Add(k_Ime);
            cmd.Parameters.Add(k_Prezime);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(k_Jmbg);
            cmd.Parameters.Add(k_Datum_rod);
            cmd.Parameters.Add(k_Komentar);
            int k = cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = konekcija.CreateCommand();
            cmd.Connection = konekcija;
            string sqlInsert2 = "insert into clanovi (id, slika, popust, metoda, clanstvo) values (:k_UId, :k_Slika, :k_Popust, :k_Metoda, :k_Clanstvo)";
            cmd.CommandText = sqlInsert2;
            OracleParameter k_UId = new OracleParameter();
            k_UId.Value = u.Sifra;
            k_UId.ParameterName = "k_UId";

            ImageConverter converter = new ImageConverter();
            byte[] sl = (byte[])converter.ConvertTo(u.Slika, typeof(byte[]));

            OracleParameter k_Slika = new OracleParameter();
            k_Slika.Value = sl;
            k_Slika.ParameterName = "k_Slika";

            OracleParameter k_Popust = new OracleParameter();
            k_Popust.Value = u.Popust;
            k_Popust.ParameterName = "k_Popust";

            OracleParameter k_Metoda = new OracleParameter();
            if (u.Metod == metoda_placanja.mjesecno)
                k_Metoda.Value = "M";
            else
                k_Metoda.Value = "G";
            k_Metoda.ParameterName = "k_Metoda";

            OracleParameter k_Clanstvo = new OracleParameter();
            if (u.Clanstvo)
                k_Clanstvo.Value = "DA";
            else
                k_Clanstvo.Value = "NE";
            k_Clanstvo.ParameterName = "k_Clanstvo";

            cmd.Parameters.Add(k_UId);
            cmd.Parameters.Add(k_Slika);
            cmd.Parameters.Add(k_Popust);
            cmd.Parameters.Add(k_Metoda);
            cmd.Parameters.Add(k_Clanstvo);
            int k2 = cmd.ExecuteNonQuery();
            cmd.Dispose();
            int k3 = 0;

            if (u is Profesor)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "insert into profesori (id, sifra) values (:k_PId, :k_S_zap)";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_S_zap = new OracleParameter();
                k_S_zap.Value = (u as Profesor).Sifra_zaposlenog;
                k_S_zap.ParameterName = "k_S_zap";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_S_zap);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            else if (u is Student)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "insert into studenti (id, indeks) values (:k_PId, :k_Index)";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_Index = new OracleParameter();
                k_Index.Value = (u as Student).Broj_indeksa;
                k_Index.ParameterName = "k_Index";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_Index);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            else if (u is MasterStudent)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "insert into master (id, indeks) values (:k_PId, :k_Index)";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_Index = new OracleParameter();
                k_Index.Value = (u as MasterStudent).Broj_indeksa;
                k_Index.ParameterName = "k_Index";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_Index);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            return k + k2 + k3;
        }

        public int dodajUposlenika(Uposleni u)
        {
            b.RegistrujUposlenog(u);
            OracleCommand cmd = konekcija.CreateCommand();
            string sqlInsert = "insert into osobe (id, ime, prezime, username, password, jmbg, datum_rod, komentar) ";
            sqlInsert += "values (:k_Id, :k_Ime, :k_Prezime, :k_Username, :k_Password, :k_Jmbg, :k_Datum_rod, :k_Komentar)";
            cmd.CommandText = sqlInsert;

            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = u.Sifra;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Ime = new OracleParameter();
            k_Ime.Value = u.Ime;
            k_Ime.ParameterName = "k_Ime";

            OracleParameter k_Prezime = new OracleParameter();
            k_Prezime.Value = u.Prezime;
            k_Prezime.ParameterName = "k_Prezime";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = u.Username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = u.Password;
            k_Password.ParameterName = "k_Password";

            OracleParameter k_Jmbg = new OracleParameter();
            k_Jmbg.Value = u.Maticni_broj;
            k_Jmbg.ParameterName = "k_Jmbg";
            OracleParameter k_Datum_rod = new OracleParameter();
            k_Datum_rod.Value = u.Datum_rodjenja;
            k_Datum_rod.ParameterName = "k_Datum_rod";

            OracleParameter k_Komentar = new OracleParameter();
            k_Komentar.Value = u.Komentar;
            k_Komentar.ParameterName = "k_Komentar";

            cmd.Parameters.Add(k_Id);
            cmd.Parameters.Add(k_Ime);
            cmd.Parameters.Add(k_Prezime);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(k_Jmbg);
            cmd.Parameters.Add(k_Datum_rod);
            cmd.Parameters.Add(k_Komentar);
            int k = cmd.ExecuteNonQuery();

            cmd = konekcija.CreateCommand();
            cmd.Connection = konekcija;
            string sqlInsert2 = "insert into uposleni (id, slika) values (:k_UId, :k_Slika)";
            cmd.CommandText = sqlInsert2;
            OracleParameter k_UId = new OracleParameter();
            k_UId.Value = u.Sifra;
            k_UId.ParameterName = "k_UId";

            ImageConverter converter = new ImageConverter();
            byte[] sl = (byte[])converter.ConvertTo(u.Slika, typeof(byte[]));

            OracleParameter k_Slika = new OracleParameter();
            k_Slika.Value = sl;
            k_Slika.ParameterName = "k_Slika";

            cmd.Parameters.Add(k_UId);
            cmd.Parameters.Add(k_Slika);
            int k2 = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return k + k2;
        }

        public int dodajKnjigu(Knjiga k)
        {
            b.RegistrujKnjigu(k);
            OracleCommand cmd = konekcija.CreateCommand();
            string insert = "insert into knjige (id, naslov, isbn, zanr, izdavac, godina, iznajmljena, vrijeme) ";
            insert += "values (:k_Id, :k_Naslov, :k_Isbn, :k_Zanr, :k_Izdavac, :k_Godina, :k_Iznajmljena, :k_Vrijeme)";
            cmd.CommandText = insert;

            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = k.Sifra_knjige;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Naslov = new OracleParameter();
            k_Naslov.Value = k.Naslov_knjige;
            k_Naslov.ParameterName = "k_Naslov";

            OracleParameter k_Isbn = new OracleParameter();
            k_Isbn.Value = k.ISBN;
            k_Isbn.ParameterName = "k_Isbn";

            OracleParameter k_Zanr = new OracleParameter();
            k_Zanr.Value = k.Zanr;
            k_Zanr.ParameterName = "k_Zanr";

            OracleParameter k_Izdavac = new OracleParameter();
            k_Izdavac.Value = k.Naziv_izdavaca;
            k_Izdavac.ParameterName = "k_Izdavac";

            OracleParameter k_Godina = new OracleParameter();
            k_Godina.Value = k.Godina_izdanja;
            k_Godina.ParameterName = "k_Godina";

            OracleParameter k_Iznajmljena = new OracleParameter();
            if (k.Iznajmljena)
                k_Iznajmljena.Value = "DA";
            else
                k_Iznajmljena.Value = "NE";
            k_Iznajmljena.ParameterName = "k_Iznajmljena";

            OracleParameter k_Vrijeme = new OracleParameter();
            k_Vrijeme.Value = k.Vrijeme;
            k_Vrijeme.ParameterName = "k_Vrijeme";

            cmd.Parameters.Add(k_Id);
            cmd.Parameters.Add(k_Naslov);
            cmd.Parameters.Add(k_Isbn);
            cmd.Parameters.Add(k_Zanr);
            cmd.Parameters.Add(k_Izdavac);
            cmd.Parameters.Add(k_Godina);
            cmd.Parameters.Add(k_Iznajmljena);
            cmd.Parameters.Add(k_Vrijeme);
            int k1 = cmd.ExecuteNonQuery();
            int k2 = 0, k3 = 0;
            OracleCommand autori = konekcija.CreateCommand();
            string aut = "insert into autori (id, knjiga_id, autor) values (sekvenca.NEXTVAL, :k_k_id, :k_autor)";
            autori.CommandText = aut;
            for (int i = 0; i < k.Spisak_autora.Count; i++)
            {
                OracleParameter k_k_id = new OracleParameter();
                k_k_id.Value = k.Sifra_knjige;
                k_k_id.ParameterName = "k_k_id";

                OracleParameter k_autor = new OracleParameter();
                k_autor.Value = k.Spisak_autora[i];
                k_autor.ParameterName = "k_autor";

                autori.Parameters.Add(k_k_id);
                autori.Parameters.Add(k_autor);
                k2 += autori.ExecuteNonQuery();
                autori.Dispose();

            }
            cmd.Dispose();

            if (k is Strip)
            {
                OracleCommand str = konekcija.CreateCommand();
                string txt = "insert into stripovi (id, ime_kuce, broj_izdanja, specijalno) values (:s_Id, :s_kuca, :s_izdanje, :s_spec)";
                str.CommandText = txt;

                OracleParameter s_Id = new OracleParameter();
                s_Id.Value = (k as Strip).Sifra_knjige;
                s_Id.ParameterName = "s_Id";

                OracleParameter s_kuca = new OracleParameter();
                s_kuca.Value = (k as Strip).Ime_kuce;
                s_kuca.ParameterName = "s_kuca";

                OracleParameter s_izdanje = new OracleParameter();
                s_izdanje.Value = (k as Strip).Broj_izdanja;
                s_izdanje.ParameterName = "s_izdanje";

                OracleParameter s_spec = new OracleParameter();
                if ((k as Strip).Specijalno)
                    s_spec.Value = "DA";
                else
                    s_spec.Value = "NE";
                s_spec.ParameterName = "s_spec";

                str.Parameters.Add(s_Id);
                str.Parameters.Add(s_kuca);
                str.Parameters.Add(s_izdanje);
                str.Parameters.Add(s_spec);

                k2 = str.ExecuteNonQuery();
                str.Dispose();

                OracleCommand cmd4 = konekcija.CreateCommand();
                string insertUmj = "insert into umjetnici (id, knjiga_id, umjetnik) values (sekvenca.NEXTVAL, :knj_id, :k_umjetnik)";
                cmd4.CommandText = insertUmj;
                for (int i = 0; i < (k as Strip).Spisak_umjetnika.Count; i++)
                {
                    OracleParameter knj_id = new OracleParameter();
                    knj_id.Value = (k as Strip).Sifra_knjige;
                    knj_id.ParameterName = "knj_id";

                    OracleParameter k_umjetnik = new OracleParameter();
                    k_umjetnik.Value = (k as Strip).Spisak_umjetnika[i];
                    k_umjetnik.ParameterName = "k_umjetnik";

                    cmd4.Parameters.Add(knj_id);
                    cmd4.Parameters.Add(k_umjetnik);
                    k3 += cmd4.ExecuteNonQuery();
                    cmd4.Dispose();
                }

            }
            if (k is NaucniRad)
            {
                OracleCommand nr = konekcija.CreateCommand();
                string naucni = "insert into naucni_radovi (id, konferencija, oblast) values (:n_id, :n_konferencija, :n_oblast)";
                nr.CommandText = naucni;

                OracleParameter n_id = new OracleParameter();
                n_id.Value = (k as NaucniRad).Sifra_knjige;
                n_id.ParameterName = "n_id";

                OracleParameter n_konferencija = new OracleParameter();
                n_konferencija.Value = (k as NaucniRad).Konferencija;
                n_konferencija.ParameterName = "n_konferencija";

                OracleParameter n_oblast = new OracleParameter();
                n_oblast.Value = (k as NaucniRad).Oblast_nauke;
                n_oblast.ParameterName = "n_oblast";

                nr.Parameters.Add(n_id);
                nr.Parameters.Add(n_konferencija);
                nr.Parameters.Add(n_oblast);

                k2 = nr.ExecuteNonQuery();
                nr.Dispose();
            }

            return k1 + k2 + k3;
        }

        public void ucitajUposlenike()
        {
            b.Uposlenici = new List<Uposleni>();
            OracleCommand command = new OracleCommand("SELECT * FROM osobe, uposleni WHERE osobe.id = uposleni.id", konekcija);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Uposleni z = new Uposleni();
                    z.Sifra = dataReader.GetInt32(0);
                    z.Ime = dataReader.GetString(1);
                    z.Prezime = dataReader.GetString(2);
                    z.Username = dataReader.GetString(3);
                    z.Password = dataReader.GetString(4);
                    z.Maticni_broj = dataReader.GetString(5);
                    z.Datum_rodjenja = dataReader.GetDateTime(6);
                    if (!dataReader.IsDBNull(7))
                        z.Komentar = dataReader.GetString(7);
                    byte[] buffer;
                    buffer = (byte[])dataReader.GetValue(9);
                    MemoryStream ms = new MemoryStream(buffer);
                    
                        z.Slika = new Bitmap(ms);
                    
                    OracleCommand com2 = konekcija.CreateCommand();
                    string komanda1 = "SELECT knjiga_id FROM osobe o, rentVeze r WHERE o.id = r.osoba_id";
                    com2.CommandText = komanda1;
                    OracleDataReader d = com2.ExecuteReader();
                    List<int> rentovi = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                rentovi.Add(d.GetInt32(0));
                        }
                    }
                    z.Iznajmljene_knjige = rentovi;
                    b.Uposlenici.Add(z);
                }
            }
        }

        public void ucitajClanove()
        {
            b.Clanovi = new List<Clan>();
            OracleCommand command = new OracleCommand("SELECT * FROM osobe o, clanovi c, profesori p WHERE o.id = c.id AND c.id = p.id ", konekcija);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Profesor z = new Profesor();
                    z.Sifra = dataReader.GetInt32(0);
                    z.Ime = dataReader.GetString(1);
                    z.Prezime = dataReader.GetString(2);
                    z.Username = dataReader.GetString(3);
                    z.Password = dataReader.GetString(4);
                    z.Maticni_broj = dataReader.GetString(5);
                    z.Datum_rodjenja = dataReader.GetDateTime(6);
                    if (!dataReader.IsDBNull(7))
                        z.Komentar = dataReader.GetString(7);
                    byte[] buffer = { };
                    if (!dataReader.IsDBNull(9))
                    {
                        buffer = (byte[])dataReader.GetValue(9);
                        MemoryStream ms = new MemoryStream(buffer);

                        z.Slika = new Bitmap(ms);
                    }
                    z.Popust = dataReader.GetDouble(10);
                    if (dataReader.GetString(11) == "M")
                        z.Metod = metoda_placanja.mjesecno;
                    else
                        z.Metod = metoda_placanja.godisnje;
                    if (dataReader.GetString(12) == "DA")
                        z.Clanstvo = true;
                    else
                        z.Clanstvo = false;
                    z.Sifra_zaposlenog = dataReader.GetInt32(14);
                    OracleCommand com2 = konekcija.CreateCommand();
                    string komanda = "SELECT knjiga_id FROM osobe o, listeZelja l WHERE o.id = l.osoba_id";
                    com2.CommandText = komanda;
                    OracleDataReader d = com2.ExecuteReader();
                    List<int> lista_zelja = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                lista_zelja.Add(d.GetInt32(0));
                        }
                    }
                    z.Lista_zelja = lista_zelja;
                    com2 = konekcija.CreateCommand();
                    string komanda1 = "SELECT knjiga_id FROM osobe o, rentVeze r WHERE o.id = r.osoba_id";
                    com2.CommandText = komanda1;
                    d = com2.ExecuteReader();
                    List<int> rentovi = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                rentovi.Add(d.GetInt32(0));
                        }
                    }
                    z.Iznajmljene_knjige = rentovi;
                    b.Clanovi.Add(z);
                }
            }

            command = new OracleCommand("SELECT * FROM osobe o, clanovi c, studenti p WHERE o.id = c.id AND c.id = p.id ", konekcija);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Student z = new Student();
                    z.Sifra = dataReader.GetInt32(0);
                    z.Ime = dataReader.GetString(1);
                    z.Prezime = dataReader.GetString(2);
                    z.Username = dataReader.GetString(3);
                    z.Password = dataReader.GetString(4);
                    z.Maticni_broj = dataReader.GetString(5);
                    z.Datum_rodjenja = dataReader.GetDateTime(6);
                    if (!dataReader.IsDBNull(7))
                        z.Komentar = dataReader.GetString(7);
                    byte[] buffer;
                    if (!dataReader.IsDBNull(9))
                    {
                        buffer = (byte[])dataReader.GetValue(9);
                        MemoryStream ms = new MemoryStream(buffer);
                        
                            z.Slika = new Bitmap(ms);
                        
                    }
                    z.Popust = dataReader.GetDouble(10);
                    if (dataReader.GetString(11) == "M")
                        z.Metod = metoda_placanja.mjesecno;
                    else
                        z.Metod = metoda_placanja.godisnje;
                    if (dataReader.GetString(12) == "DA")
                        z.Clanstvo = true;
                    else
                        z.Clanstvo = false;
                    z.Broj_indeksa = dataReader.GetInt32(14);
                    OracleCommand com2 = konekcija.CreateCommand();
                    string komanda = "SELECT knjiga_id FROM osobe o, listeZelja l WHERE o.id = l.osoba_id";
                    com2.CommandText = komanda;
                    OracleDataReader d = com2.ExecuteReader();
                    List<int> lista_zelja = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                lista_zelja.Add(d.GetInt32(0));
                        }
                    }
                    z.Lista_zelja = lista_zelja;
                    com2 = konekcija.CreateCommand();
                    string komanda1 = "SELECT knjiga_id FROM osobe o, rentVeze r WHERE o.id = r.osoba_id";
                    com2.CommandText = komanda1;
                    d = com2.ExecuteReader();
                    List<int> rentovi = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                rentovi.Add(d.GetInt32(0));
                        }
                    }
                    z.Iznajmljene_knjige = rentovi;
                    b.Clanovi.Add(z);
                }
            }

            command = new OracleCommand("SELECT * FROM osobe o, clanovi c, master p WHERE o.id = c.id AND c.id = p.id ", konekcija);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    MasterStudent z = new MasterStudent();
                    z.Sifra = dataReader.GetInt32(0);
                    z.Ime = dataReader.GetString(1);
                    z.Prezime = dataReader.GetString(2);
                    z.Username = dataReader.GetString(3);
                    z.Password = dataReader.GetString(4);
                    z.Maticni_broj = dataReader.GetString(5);
                    z.Datum_rodjenja = dataReader.GetDateTime(6);
                    if (!dataReader.IsDBNull(7))
                        z.Komentar = dataReader.GetString(7);
                    byte[] buffer;
                    if (!dataReader.IsDBNull(9))
                    {
                        buffer = (byte[])dataReader.GetValue(9);
                        MemoryStream ms = new MemoryStream(buffer);
                        
                            z.Slika = new Bitmap(ms);
                        
                    }
                    z.Popust = dataReader.GetDouble(10);
                    if (dataReader.GetString(11) == "M")
                        z.Metod = metoda_placanja.mjesecno;
                    else
                        z.Metod = metoda_placanja.godisnje;
                    if (dataReader.GetString(12) == "DA")
                        z.Clanstvo = true;
                    else
                        z.Clanstvo = false;
                    z.Broj_indeksa = dataReader.GetInt32(14);
                    OracleCommand com2 = konekcija.CreateCommand();
                    string komanda = "SELECT knjiga_id FROM osobe o, listeZelja l WHERE o.id = l.osoba_id";
                    com2.CommandText = komanda;
                    OracleDataReader d = com2.ExecuteReader();
                    List<int> lista_zelja = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                lista_zelja.Add(d.GetInt32(0));
                        }
                    }
                    z.Lista_zelja = lista_zelja;
                    com2 = konekcija.CreateCommand();
                    string komanda1 = "SELECT knjiga_id FROM osobe o, rentVeze r WHERE o.id = r.osoba_id";
                    com2.CommandText = komanda1;
                    d = com2.ExecuteReader();
                    List<int> rentovi = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                rentovi.Add(d.GetInt32(0));
                        }
                    }
                    Console.WriteLine(rentovi.Count);
                    z.Iznajmljene_knjige = rentovi;
                    b.Clanovi.Add(z);
                }
            }

            command = new OracleCommand("SELECT * FROM osobe o, clanovi c WHERE o.id = c.id ", konekcija);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Clan z = new Clan();
                    z.Sifra = dataReader.GetInt32(0);
                    bool brejk = false;
                    for (int i = 0; i < b.Clanovi.Count; i++)
                        if (z.Sifra == b.Clanovi[i].Sifra)
                        {
                            brejk = true;
                            break;
                        }
                    if (brejk) continue;
                    z.Ime = dataReader.GetString(1);
                    z.Prezime = dataReader.GetString(2);
                    z.Username = dataReader.GetString(3);
                    z.Password = dataReader.GetString(4);
                    z.Maticni_broj = dataReader.GetString(5);
                    z.Datum_rodjenja = dataReader.GetDateTime(6);
                    if (!dataReader.IsDBNull(7))
                        z.Komentar = dataReader.GetString(7);
                    if (!dataReader.IsDBNull(9))
                    {
                        byte[] buffer;
                        buffer = (byte[])dataReader.GetValue(9);
                        MemoryStream ms = new MemoryStream(buffer);
                        
                            z.Slika = new Bitmap(ms);
                        
                    }
                    z.Popust = dataReader.GetDouble(10);
                    if (dataReader.GetString(11) == "M")
                        z.Metod = metoda_placanja.mjesecno;
                    else
                        z.Metod = metoda_placanja.godisnje;
                    if (dataReader.GetString(12) == "DA")
                        z.Clanstvo = true;
                    else
                        z.Clanstvo = false;
                    OracleCommand com2 = konekcija.CreateCommand();
                    string komanda = "SELECT knjiga_id FROM osobe o, listeZelja l WHERE o.id = l.osoba_id";
                    com2.CommandText = komanda;
                    OracleDataReader d = com2.ExecuteReader();
                    List<int> lista_zelja = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                lista_zelja.Add(d.GetInt32(0));
                        }
                    }
                    z.Lista_zelja = lista_zelja;
                    com2 = konekcija.CreateCommand();
                    string komanda1 = "SELECT knjiga_id FROM osobe o, rentVeze r WHERE o.id = r.osoba_id";
                    com2.CommandText = komanda1;
                    d = com2.ExecuteReader();
                    List<int> rentovi = new List<int>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            if (!d.IsDBNull(0))
                                rentovi.Add(d.GetInt32(0));
                        }
                    }
                    z.Iznajmljene_knjige = rentovi;
                    b.Clanovi.Add(z);
                }
            }
        }

        public void ucitajKnjige()
        {
            OracleCommand komanda = konekcija.CreateCommand();
            string strip_komanda = "SELECT * FROM knjige k, stripovi s WHERE k.id = s.id";
            komanda.CommandText = strip_komanda;
            dataReader = komanda.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Strip s = new Strip();
                    s.Sifra_knjige = dataReader.GetInt32(0);
                    s.Naslov_knjige = dataReader.GetString(1);
                    s.ISBN = dataReader.GetString(2);
                    s.Zanr = dataReader.GetString(3);
                    s.Naziv_izdavaca = dataReader.GetString(4);
                    s.Godina_izdanja = dataReader.GetInt32(5);
                    if (dataReader.GetString(6) == "DA")
                        s.Iznajmljena = true;
                    else
                        s.Iznajmljena = false;
                    s.Vrijeme = dataReader.GetInt32(7);
                    s.Ime_kuce = dataReader.GetString(9);
                    s.Broj_izdanja = dataReader.GetInt32(10);
                    if (dataReader.GetString(11) == "DA")
                        s.Specijalno = true;
                    else
                        s.Specijalno = false;
                    OracleCommand com = konekcija.CreateCommand();
                    string autori = "SELECT autor FROM knjige k, autori a WHERE k.id = a.knjiga_id";
                    com.CommandText = autori;
                    OracleDataReader d = com.ExecuteReader();
                    List<string> aut = new List<string>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            aut.Add(d.GetString(0));
                        }
                    }
                    s.Spisak_autora = aut;
                    com = konekcija.CreateCommand();
                    autori = "SELECT umjetnik FROM knjige k, umjetnici u WHERE k.id = u.knjiga_id";
                    com.CommandText = autori;
                    List<string> umj = new List<string>();
                    d = com.ExecuteReader();
                    if (d.HasRows)
                    {
                        while (d.Read())
                            umj.Add(d.GetString(0));
                    }
                    s.Spisak_umjetnika = umj;
                    
                    b.Knjige.Add(s);
                }
            }

            OracleCommand comm = konekcija.CreateCommand();
            string tekst = "SELECT * FROM knjige k, naucni_radovi n WHERE k.id = n.id";
            comm.CommandText = tekst;
            dataReader = comm.ExecuteReader();
            if (dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    NaucniRad s = new NaucniRad();
                    s.Sifra_knjige = dataReader.GetInt32(0);
                    s.Naslov_knjige = dataReader.GetString(1);
                    s.ISBN = dataReader.GetString(2);
                    s.Zanr = dataReader.GetString(3);
                    s.Naziv_izdavaca = dataReader.GetString(4);
                    s.Godina_izdanja = dataReader.GetInt32(5);
                    if (dataReader.GetString(6) == "DA")
                        s.Iznajmljena = true;
                    else
                        s.Iznajmljena = false;
                    s.Vrijeme = dataReader.GetInt32(7);
                    
                    OracleCommand com = konekcija.CreateCommand();
                    string autori = "SELECT autor FROM knjige k, autori a WHERE k.id = a.knjiga_id";
                    com.CommandText = autori;
                    OracleDataReader d = com.ExecuteReader();
                    List<string> aut = new List<string>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            aut.Add(d.GetString(0));
                        }
                    }
                    s.Spisak_autora = aut;
                    s.Konferencija = dataReader.GetString(9);
                    s.Oblast_nauke = dataReader.GetString(10);
                   
                    b.Knjige.Add(s);
                }
            }

            OracleCommand obicne = konekcija.CreateCommand();
            string ok = "SELECT * FROM knjige";
            obicne.CommandText = ok;
            dataReader = obicne.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Knjiga s = new Knjiga();
                   
                    s.Sifra_knjige = dataReader.GetInt32(0);
                    bool brejk = false;
                    for (int i = 0; i < b.Knjige.Count; i++)
                    {
                       
                        if (s.Sifra_knjige == b.Knjige[i].Sifra_knjige)
                        {
                            brejk = true;
                            break;
                        }

                   }
                    if (brejk) continue;
                    s.Naslov_knjige = dataReader.GetString(1);
                    s.ISBN = dataReader.GetString(2);
                    s.Zanr = dataReader.GetString(3);
                    s.Naziv_izdavaca = dataReader.GetString(4);
                    s.Godina_izdanja = dataReader.GetInt32(5);
                    if (dataReader.GetString(6) == "DA")
                        s.Iznajmljena = true;
                    else
                        s.Iznajmljena = false;
                    s.Vrijeme = dataReader.GetInt32(7);

                    OracleCommand com = konekcija.CreateCommand();
                    string autori = "SELECT autor FROM knjige k, autori a WHERE k.id = a.knjiga_id";
                    com.CommandText = autori;
                    OracleDataReader d = com.ExecuteReader();
                    List<string> aut = new List<string>();
                    if (d.HasRows)
                    {
                        while (d.Read())
                        {
                            aut.Add(d.GetString(0));
                        }
                    }
                    s.Spisak_autora = aut;
                    b.Knjige.Add(s);
                }
            }


        }

        public int iznajmiKnjiguClanu(int sifra1, int sifra2)
        {
            b.IznajmiKnjiguClanu(sifra1, sifra2);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "insert into rentVeze (veza_id, osoba_id, knjiga_id) values (sekvenca.NEXTVAL, :id, :sifra)";
            c.CommandText = txt;

            OracleParameter id = new OracleParameter();
            id.Value = sifra1;
            id.ParameterName = "id";

            OracleParameter sifra = new OracleParameter();
            sifra.Value = sifra2;
            sifra.ParameterName = "sifra";

            c.Parameters.Add(id);
            c.Parameters.Add(sifra);
            int k = c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            string txt2 = "update knjige set iznajmljena = :iz where id = :id1";
            c.CommandText = txt2;
            OracleParameter iz = new OracleParameter();
            iz.Value = "DA";
            iz.ParameterName = "iz";

            OracleParameter id1 = new OracleParameter();
            id1.Value = sifra2;
            id1.ParameterName = "id1";

            c.Parameters.Add(iz);
            c.Parameters.Add(id1);
            int k2 = c.ExecuteNonQuery();
            c.Dispose();
            return k + k2;
        }

        public int iznajmiKnjiguUposlenom(int sifra1, int sifra2)
        {
            b.IznajmiKnjiguUposlenom(sifra1, sifra2);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "insert into rentVeze (veza_id, osoba_id, knjiga_id) values (sekvenca.NEXTVAL, :id, :sifra)";
            c.CommandText = txt;

            OracleParameter id = new OracleParameter();
            id.Value = sifra1;
            id.ParameterName = "id";

            OracleParameter sifra = new OracleParameter();
            sifra.Value = sifra2;
            sifra.ParameterName = "sifra";

            c.Parameters.Add(id);
            c.Parameters.Add(sifra);
            int k = c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            string txt2 = "update knjige set iznajmljena = :iz where id = :id1";
            c.CommandText = txt2;
            OracleParameter iz = new OracleParameter();
            iz.Value = "DA";
            iz.ParameterName = "iz";

            OracleParameter id1 = new OracleParameter();
            id1.Value = sifra2;
            id1.ParameterName = "id1";

            c.Parameters.Add(iz);
            c.Parameters.Add(id1);
            int k2 = c.ExecuteNonQuery();
            c.Dispose();
            return k + k2;
        }

        public int vratiKnjigu(int sifra)
        {
            b.VratiKnjigu(sifra);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "delete from rentVeze where knjiga_id = :sif";
            c.CommandText = txt;

            OracleParameter sif = new OracleParameter();
            sif.Value = sifra;
            sif.ParameterName = "sif";
            c.Parameters.Add(sif);
            int k = c.ExecuteNonQuery();
            c.Dispose();

            OracleCommand c1 = konekcija.CreateCommand();
            string txt1 = "update knjige set iznajmljena = :iz where id = :id";
            c1.CommandText = txt1;

            OracleParameter iz = new OracleParameter();
            iz.Value = "NE";
            iz.ParameterName = "iz";

            OracleParameter id = new OracleParameter();
            id.Value = sifra;
            id.ParameterName = "id";

            c1.Parameters.Add(iz);
            c1.Parameters.Add(id);
            int k2 = c1.ExecuteNonQuery();
            c1.Dispose();
            return k + k2;
        }

        public int brisiKnjigu(int sifr)
        {
            b.BrisiKnjigu(sifr);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "delete from naucni_radovi where id = :sif";
            string txt2 = "delete from stripovi where id = :sif";
            string txt3 = "delete from knjige where id = :sif";
            string txt4 = "delete from rentVeze where knjiga_id = :sif";
            string txt5 = "delete from listeZelja where knjiga_id = :sif";
            string txt6 = "delete from autori where knjiga_id = :sif";
            string txt7 = "delete from umjetnici where knjiga_id = :sif";
            c.CommandText = txt;
            OracleParameter sif = new OracleParameter();
            sif.Value = sifr;
            sif.ParameterName = "sif";
            int k = 0;
            c.Parameters.Add(sif);
            k = c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt2;
            OracleParameter sif1 = new OracleParameter();
            sif1.Value = sifr;
            sif1.ParameterName = "sif";
            c.Parameters.Add(sif1);
            k += c.ExecuteNonQuery();
            c.Dispose();

            

            c = konekcija.CreateCommand();
            c.CommandText = txt4;
            OracleParameter sif3 = new OracleParameter();
            sif3.Value = sifr;
            sif3.ParameterName = "sif";
            c.Parameters.Add(sif3);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt5;
            OracleParameter sif4 = new OracleParameter();
            sif4.Value = sifr;
            sif4.ParameterName = "sif";
            c.Parameters.Add(sif4);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt6;
            OracleParameter sif5 = new OracleParameter();
            sif5.Value = sifr;
            sif5.ParameterName = "sif";
            c.Parameters.Add(sif5);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt7;
            OracleParameter sif6 = new OracleParameter();
            sif6.Value = sifr;
            sif6.ParameterName = "sif";
            c.Parameters.Add(sif6);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt3;
            OracleParameter sif2 = new OracleParameter();
            sif2.Value = sifr;
            sif2.ParameterName = "sif";
            c.Parameters.Add(sif2);
            k += c.ExecuteNonQuery();
            c.Dispose();

            return k;
        }

        public int brisiClana(int sifra)
        {
            b.BrisiClana(sifra);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "delete from master where id = :id";
            string txt2 = "delete from studenti where id = :id";
            string txt3 = "delete from profesori where id = :id";
            string txt4 = "delete from clanovi where id = :id";
            string txt5 = "delete from osobe where id = :id";
            string txt6 = "delete from listeZelja where osoba_id = :id";
            string txt7 = "delete from rentVeze where osoba_id = :id";

            int k = 0;

            c.CommandText = txt;
            OracleParameter o1 = new OracleParameter();
            o1.Value = sifra;
            o1.ParameterName = "id";
            c.Parameters.Add(o1);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt2;
            OracleParameter o2 = new OracleParameter();
            o2.Value = sifra;
            o2.ParameterName = "id";
            c.Parameters.Add(o2);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt3;
            OracleParameter o3 = new OracleParameter();
            o3.Value = sifra;
            o3.ParameterName = "id";
            c.Parameters.Add(o3);
            k += c.ExecuteNonQuery();
            c.Dispose();

           

           

            c = konekcija.CreateCommand();
            c.CommandText = txt6;
            OracleParameter o6 = new OracleParameter();
            o6.Value = sifra;
            o6.ParameterName = "id";
            c.Parameters.Add(o6);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt7;
            OracleParameter o7 = new OracleParameter();
            o7.Value = sifra;
            o7.ParameterName = "id";
            c.Parameters.Add(o7);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt4;
            OracleParameter o4 = new OracleParameter();
            o4.Value = sifra;
            o4.ParameterName = "id";
            c.Parameters.Add(o4);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt5;
            OracleParameter o5 = new OracleParameter();
            o5.Value = sifra;
            o5.ParameterName = "id";
            c.Parameters.Add(o5);
            k += c.ExecuteNonQuery();
            c.Dispose();

            return k;
        }

        public int brisiUposlenog(int sifra)
        {
            b.BrisiUposlenog(sifra);
            OracleCommand c = konekcija.CreateCommand();
            string txt = "delete from uposleni where id = :id";
            string txt2 = "delete from osobe where id = :id";
            string txt3 = "delete from rentVeze where osoba_id = :id";

            int k = 0;

            c.CommandText = txt;
            OracleParameter o1 = new OracleParameter();
            o1.Value = sifra;
            o1.ParameterName = "id";
            c.Parameters.Add(o1);
            k += c.ExecuteNonQuery();
            c.Dispose();

            

            c = konekcija.CreateCommand();
            c.CommandText = txt3;
            OracleParameter o3 = new OracleParameter();
            o3.Value = sifra;
            o3.ParameterName = "id";
            c.Parameters.Add(o3);
            k += c.ExecuteNonQuery();
            c.Dispose();

            c = konekcija.CreateCommand();
            c.CommandText = txt2;
            OracleParameter o2 = new OracleParameter();
            o2.Value = sifra;
            o2.ParameterName = "id";
            c.Parameters.Add(o2);
            k += c.ExecuteNonQuery();
            c.Dispose();
            return k;
        }

        public int azurirajClana(Clan u)
        {

            OracleCommand cmd = konekcija.CreateCommand();
            string insert = "update osobe set id = :k_Id, ime = :k_Ime, prezime = :k_Prezime, username = :k_Username, " +
                            "password = :k_Password, jmbg = :k_Jmbg, datum_rod = :k_Datum_rod, komentar = :k_Komentar where id = :k_Id";
            cmd.CommandText = insert;

            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = u.Sifra;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Ime = new OracleParameter();
            k_Ime.Value = u.Ime;
            k_Ime.ParameterName = "k_Ime";

            OracleParameter k_Prezime = new OracleParameter();
            k_Prezime.Value = u.Prezime;
            k_Prezime.ParameterName = "k_Prezime";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = u.Username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = u.Password;
            k_Password.ParameterName = "k_Password";

            OracleParameter k_Jmbg = new OracleParameter();
            k_Jmbg.Value = u.Maticni_broj;
            k_Jmbg.ParameterName = "k_Jmbg";
            OracleParameter k_Datum_rod = new OracleParameter();
            k_Datum_rod.Value = u.Datum_rodjenja;
            k_Datum_rod.ParameterName = "k_Datum_rod";

            OracleParameter k_Komentar = new OracleParameter();
            k_Komentar.Value = u.Komentar;
            k_Komentar.ParameterName = "k_Komentar";

            cmd.Parameters.Add(k_Id);
            cmd.Parameters.Add(k_Ime);
            cmd.Parameters.Add(k_Prezime);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(k_Jmbg);
            cmd.Parameters.Add(k_Datum_rod);
            cmd.Parameters.Add(k_Komentar);
            int k = cmd.ExecuteNonQuery();

            cmd = konekcija.CreateCommand();
            cmd.Connection = konekcija;
            string sqlInsert2 = "update clanovi set id = :k_UId, slika = :k_Slika, popust = :k_Popust, metoda = :k_Metoda, clanstvo = :k_Clanstvo  where id = :k_UId";
            cmd.CommandText = sqlInsert2;
            OracleParameter k_UId = new OracleParameter();
            k_UId.Value = u.Sifra;
            k_UId.ParameterName = "k_UId";

            ImageConverter converter = new ImageConverter();
            byte[] sl = (byte[])converter.ConvertTo(u.Slika, typeof(byte[]));

            OracleParameter k_Slika = new OracleParameter();
            k_Slika.Value = sl;
            k_Slika.ParameterName = "k_Slika";

            OracleParameter k_Popust = new OracleParameter();
            k_Popust.Value = u.Popust;
            k_Popust.ParameterName = "k_Popust";

            OracleParameter k_Metoda = new OracleParameter();
            if (u.Metod == metoda_placanja.mjesecno)
                k_Metoda.Value = "M";
            else
                k_Metoda.Value = "G";
            k_Metoda.ParameterName = "k_Metoda";

            OracleParameter k_Clanstvo = new OracleParameter();
            if (u.Clanstvo)
                k_Clanstvo.Value = "DA";
            else
                k_Clanstvo.Value = "NE";
            k_Clanstvo.ParameterName = "k_Clanstvo";

            cmd.Parameters.Add(k_UId);
            cmd.Parameters.Add(k_Slika);
            cmd.Parameters.Add(k_Popust);
            cmd.Parameters.Add(k_Metoda);
            cmd.Parameters.Add(k_Clanstvo);
            int k2 = cmd.ExecuteNonQuery();
            cmd.Dispose();

            int k3 = 0;

            if (u is Profesor)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "update profesori set id = :k_PId, sifra = :k_S_zap  where id = :k_PId";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_S_zap = new OracleParameter();
                k_S_zap.Value = (u as Profesor).Sifra_zaposlenog;
                k_S_zap.ParameterName = "k_S_zap";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_S_zap);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            else if (u is Student)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "update studenti set id = :k_PId, indeks = :k_Index where id = :k_PId";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_Index = new OracleParameter();
                k_Index.Value = (u as Student).Broj_indeksa;
                k_Index.ParameterName = "k_Index";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_Index);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            else if (u is MasterStudent)
            {
                OracleCommand cmd2 = konekcija.CreateCommand();
                string text = "update master set id = :k_PId, indeks = :k_Index where id = :k_PId";
                cmd2.CommandText = text;
                OracleParameter k_PId = new OracleParameter();
                k_PId.Value = u.Sifra;
                k_PId.ParameterName = "k_PId";

                OracleParameter k_Index = new OracleParameter();
                k_Index.Value = (u as MasterStudent).Broj_indeksa;
                k_Index.ParameterName = "k_Index";
                cmd2.Parameters.Add(k_PId);
                cmd2.Parameters.Add(k_Index);
                k3 = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            return k + k2 + k3;
        }

        public int azurirajKnjigu(Knjiga k)
        {
            OracleCommand cmd = konekcija.CreateCommand();
            string update = "update knjige set id = :k_Id, naslov = :k_Naslov, isbn = :k_Isbn, zanr = :k_Zanr, " +
                            "izdavac = :k_Izdavac, godina = :k_Godina, iznajmljena = :k_Iznajmljena, vrijeme = :k_Vrijeme where id = :k_Idd";   
            cmd.CommandText = update;

            OracleParameter k_Idd = new OracleParameter();
            k_Idd.Value = k.Sifra_knjige;
            k_Idd.ParameterName = "k_Idd";

            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = k.Sifra_knjige;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Naslov = new OracleParameter();
            k_Naslov.Value = k.Naslov_knjige;
            k_Naslov.ParameterName = "k_Naslov";

            OracleParameter k_Isbn = new OracleParameter();
            k_Isbn.Value = k.ISBN;
            k_Isbn.ParameterName = "k_Isbn";

            OracleParameter k_Zanr = new OracleParameter();
            k_Zanr.Value = k.Zanr;
            k_Zanr.ParameterName = "k_Zanr";

            OracleParameter k_Izdavac = new OracleParameter();
            k_Izdavac.Value = k.Naziv_izdavaca;
            k_Izdavac.ParameterName = "k_Izdavac";

            OracleParameter k_Godina = new OracleParameter();
            k_Godina.Value = k.Godina_izdanja;
            k_Godina.ParameterName = "k_Godina";

            OracleParameter k_Iznajmljena = new OracleParameter();
            if (k.Iznajmljena)
                k_Iznajmljena.Value = "DA";
            else
                k_Iznajmljena.Value = "NE";
            k_Iznajmljena.ParameterName = "k_Iznajmljena";

            OracleParameter k_Vrijeme = new OracleParameter();
            k_Vrijeme.Value = k.Vrijeme;
            k_Vrijeme.ParameterName = "k_Vrijeme";

            cmd.Parameters.Add(k_Id);
            cmd.Parameters.Add(k_Naslov);
            cmd.Parameters.Add(k_Isbn);
            cmd.Parameters.Add(k_Zanr);
            cmd.Parameters.Add(k_Izdavac);
            cmd.Parameters.Add(k_Godina);
            cmd.Parameters.Add(k_Iznajmljena);
            cmd.Parameters.Add(k_Vrijeme);
            cmd.Parameters.Add(k_Idd);
            int k1 = cmd.ExecuteNonQuery();
            int k2 = 0, k3 = 0;
           
            cmd.Dispose();

            if (k is Strip)
            {
                OracleCommand str = konekcija.CreateCommand();
                string txt = "update stripovi set id = :s_Id, ime_kuce = :s_kuca, broj_izdanja = :s_izdanje, specijalno = :s_spec where id = :k_Id"; 
                str.CommandText = txt;

                OracleParameter s_Id = new OracleParameter();
                s_Id.Value = (k as Strip).Sifra_knjige;
                s_Id.ParameterName = "s_Id";

                OracleParameter s_kuca = new OracleParameter();
                s_kuca.Value = (k as Strip).Ime_kuce;
                s_kuca.ParameterName = "s_kuca";

                OracleParameter s_izdanje = new OracleParameter();
                s_izdanje.Value = (k as Strip).Broj_izdanja;
                s_izdanje.ParameterName = "s_izdanje";

                OracleParameter s_spec = new OracleParameter();
                if ((k as Strip).Specijalno)
                    s_spec.Value = "DA";
                else
                    s_spec.Value = "NE";
                s_spec.ParameterName = "s_spec";

                str.Parameters.Add(s_Id);
                str.Parameters.Add(s_kuca);
                str.Parameters.Add(s_izdanje);
                str.Parameters.Add(s_spec);

                k2 = str.ExecuteNonQuery();
                str.Dispose();

                

            }
            if (k is NaucniRad)
            {
                OracleCommand nr = konekcija.CreateCommand();
                string naucni = "update naucni_radovi set konferencija = :n_konferencija, oblast = :n_oblast where id = :pid";
                nr.CommandText = naucni;

               

                OracleParameter k_id = new OracleParameter();
                k_id.Value = (k as NaucniRad).Sifra_knjige;
                k_id.ParameterName = "pid";

                OracleParameter n_konferencija = new OracleParameter();
     
                    n_konferencija.Value = (k as NaucniRad).Konferencija;
                n_konferencija.ParameterName = "n_konferencija";

                OracleParameter n_oblast = new OracleParameter();
               
                    n_oblast.Value = (k as NaucniRad).Oblast_nauke;
                n_oblast.ParameterName = "n_oblast";

       
                nr.Parameters.Add(n_konferencija);
                nr.Parameters.Add(n_oblast);
                nr.Parameters.Add(k_id);

                k2 = nr.ExecuteNonQuery();
                nr.Dispose();
            }

            return k1 + k2 + k3;
        }

        public int azurirajUposlenika(Uposleni u)
        {
            OracleCommand cmd = konekcija.CreateCommand();
            string sqlInsert = "update osobe set ime = :k_Ime, prezime = :k_Prezime, username = :k_Username, " +
                            "password = :k_Password, jmbg = :k_Jmbg, datum_rod = :k_Datum_rod where id = :k_Id";
            cmd.CommandText = sqlInsert;


            OracleParameter k_Id = new OracleParameter();
            k_Id.Value = u.Sifra;
            k_Id.ParameterName = "k_Id";

            OracleParameter k_Ime = new OracleParameter();
            k_Ime.Value = u.Ime;
            k_Ime.ParameterName = "k_Ime";

            OracleParameter k_Prezime = new OracleParameter();
            k_Prezime.Value = u.Prezime;
            k_Prezime.ParameterName = "k_Prezime";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = u.Username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = u.Password;
            k_Password.ParameterName = "k_Password";

            OracleParameter k_Jmbg = new OracleParameter();
            k_Jmbg.Value = u.Maticni_broj;
            k_Jmbg.ParameterName = "k_Jmbg";
            OracleParameter k_Datum_rod = new OracleParameter();
            k_Datum_rod.Value = u.Datum_rodjenja;
            k_Datum_rod.ParameterName = "k_Datum_rod";

            OracleParameter k_Komentar = new OracleParameter();
            if (u.Komentar != "")
                k_Komentar.Value = u.Komentar;
            k_Komentar.ParameterName = "k_Komentar";

            

            
            cmd.Parameters.Add(k_Ime);
            cmd.Parameters.Add(k_Prezime);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(k_Jmbg);
            cmd.Parameters.Add(k_Datum_rod);
            cmd.Parameters.Add(k_Id);

            int k = cmd.ExecuteNonQuery();

            cmd.Dispose();
           
            cmd = konekcija.CreateCommand();
            cmd.Connection = konekcija;
            string sqlInsert2 = "update uposleni set slika = :k_Slika where id = :k_UIdd"; 
            cmd.CommandText = sqlInsert2;

            OracleParameter k_UIdd = new OracleParameter();
            k_UIdd.Value = u.Sifra;
            k_UIdd.ParameterName = "k_UIdd";


            ImageConverter converter = new ImageConverter();
            byte[] sl = (byte[])converter.ConvertTo(u.Slika, typeof(byte[]));

            OracleParameter k_Slika = new OracleParameter();
            k_Slika.Value = sl;
            k_Slika.ParameterName = "k_Slika";

            cmd.Parameters.Add(k_Slika);
            cmd.Parameters.Add(k_UIdd);
            int k2 = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return k + k2;
        }

        public int dodajNaListuZelja(int s1, int s2)
        {
            OracleCommand c = konekcija.CreateCommand();
            string txt = "insert into rentVeze (id, osoba_id, knjiga_id) values (sekvenca.NEXTVAL, :o_id, :k_id)";
            c.CommandText = txt;

            OracleParameter o_id = new OracleParameter();
            o_id.Value = s1;
            o_id.ParameterName = "o_id";

            OracleParameter k_id = new OracleParameter();
            k_id.Value = s2;
            k_id.ParameterName = "k_id";

            c.Parameters.Add(k_id);
            c.Parameters.Add(o_id);

            int k = c.ExecuteNonQuery();
            c.Dispose();
            return k;

        }
    } 
}
