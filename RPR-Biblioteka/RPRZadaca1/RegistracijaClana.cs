using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.RegularExpressions;
using System.Text.RegularExpressions;
using RPRZadaca2;
using System.Threading;
using System.Data.OracleClient;

namespace RPRZadaca1
{
    public partial class RegistracijaClana : Form
    {
        BibliotekaBaza b;
        Clan c;
        public RegistracijaClana()
        {
            InitializeComponent();
        }

        public RegistracijaClana(BibliotekaBaza bb)
        {
            b = bb;
            InitializeComponent();
        }

        public RegistracijaClana(BibliotekaBaza bb, Clan cc)
        {
            b = bb;
            c = cc;
            
            InitializeComponent();
            textBoxIme.Text = c.Ime;
            textBoxPrezime.Text = c.Prezime;
            dateTimePicker1.Value = c.Datum_rodjenja;
            textBoxJMBG.Text = c.Maticni_broj;
            if (c.Metod == metoda_placanja.mjesecno)
                radioButtonMjesecno.Checked = true;
            else
                radioButtonGodisnje.Checked = true;
            if (c is Student)
            {
                radioButtonStudent.Checked = true;
                labelIndex.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = (c as Student).Broj_indeksa.ToString();
            }
            else if (c is MasterStudent)
            {
                radioButtonMaster.Checked = true;
                labelIndex.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = (c as MasterStudent).Broj_indeksa.ToString();
            }
            else if (c is Profesor)
            {
                radioButtonProfesor.Checked = true;
                labelSifra.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = (c as Profesor).Sifra_zaposlenog.ToString();

            }
            else
                radioButtonObicni.Checked = true;
            ubacivanjeSlike1.Slika = c.Slika;
            radioButtonObicni.Enabled = false;
            radioButtonStudent.Enabled = false;
            radioButtonMaster.Enabled = false;
            radioButtonProfesor.Enabled = false;
            textBoxIndex.Enabled = false;
            textBoxUsername.Text = c.Username;
            textBoxPassword.Text = c.Password;
            textBoxPotvrda.Text = c.Password;
            button1.Visible = true;
            buttonRegistruj.Visible = false;

        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            labelSifra.Visible = false;
            labelIndex.Visible = true;
            textBoxIndex.Visible = true;
            
        }

        private void radioButtonObicni_CheckedChanged(object sender, EventArgs e)
        {
            labelSifra.Visible = false;
            labelIndex.Visible = false;
            textBoxIndex.Visible = false;
        }

        private void radioButtonMaster_CheckedChanged(object sender, EventArgs e)
        {
            labelSifra.Visible = false;
            labelIndex.Visible = true;
            textBoxIndex.Visible = true;
        }

        private void radioButtonProfesor_CheckedChanged(object sender, EventArgs e)
        {
            labelIndex.Visible = false;
            labelSifra.Visible = true;
            textBoxIndex.Visible = true;
        }

      

        private void buttonRegistruj_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    string met = "";
                    if (radioButtonMjesecno.Checked) met = "M";
                    else met = "G";
                    if (radioButtonMaster.Checked)
                    {
                        try
                        {
                            b.otvoriKonekciju();
                            
                            int res = b.dodajClana(new MasterStudent(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", Convert.ToInt32(textBoxIndex.Text), met, textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika));
                            
                            b.zatvoriKonekciju();
                            toolStripStatusLabel1.Text = "Broj redova: " + res.ToString();
                        }
                        catch (Exception ex)
                        {
                            toolStripStatusLabel1.Text = ex.Message;

                        }
                    }
                    else if (radioButtonObicni.Checked)
                    {
                        try
                        {
                            b.otvoriKonekciju();
                           

                            int res = b.dodajClana(new Clan(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", met, textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika));
                            
                            b.zatvoriKonekciju();
                            toolStripStatusLabel1.Text = "Broj redova: " + res.ToString();
                        }
                        catch (Exception ex)
                        {
                            toolStripStatusLabel1.Text = ex.Message;
                        }
                    }
                    else if (radioButtonStudent.Checked)
                    {
                        try
                        {
                            b.otvoriKonekciju();
                            
                            int res = b.dodajClana(new Student(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", Convert.ToInt32(textBoxIndex.Text), met, textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika));
                           
                            b.zatvoriKonekciju();
                            toolStripStatusLabel1.Text = "Broj redova: " + res.ToString();
                        }
                        catch (Exception ex)
                        {
                            toolStripStatusLabel1.Text = ex.Message;
                        }
                    }
                    else
                    {
                        try
                        {
                           b.otvoriKonekciju();
                            

                            int res = b.dodajClana(new Profesor(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", Convert.ToInt32(textBoxIndex.Text), met, textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika));
                           

                            b.zatvoriKonekciju();
                            toolStripStatusLabel1.Text = "Broj redova: " + res.ToString();
                        }

                        catch (Exception ex)
                        {
                            toolStripStatusLabel1.Text = ex.Message;
                        }
                    }
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxIme.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxIme, "Ime mora biti 3 karaktera ili više!");
                textBoxIme.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greška";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBoxIme_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxIme.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxIme.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrezime.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxPrezime, "Prezime mora biti 3 karaktera ili više!");
                textBoxPrezime.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greška";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBoxPrezime_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPrezime.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPrezime.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        

        private void textBoxJMBG_Validating_1(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < textBoxJMBG.Text.Length; i++)
                if (textBoxJMBG.Text[i] < '0' || textBoxJMBG.Text[i] > '9')
                {
                    errorProvider1.SetError(textBoxJMBG, "Nisu dozvoljeni znakovi koji nisu brojevi!");
                    textBoxJMBG.BackColor = Color.Red;
                    toolStripStatusLabel1.Text = "Greska!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
            if (textBoxJMBG.Text.Length != 13)
            {
                errorProvider1.SetError(textBoxJMBG, "Duzina mora biti tacno 13!");
                textBoxJMBG.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
            else if (Convert.ToInt32(textBoxJMBG.Text.Substring(0, 2)) != dateTimePicker1.Value.Day)
            {
                errorProvider1.SetError(textBoxJMBG, "Dan nije validan!");
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                textBoxJMBG.SelectionStart = 0;
                textBoxJMBG.SelectionLength = 2;
                textBoxJMBG.SelectionColor = Color.Red;
                textBoxJMBG.SelectionBackColor = Color.Yellow;
                e.Cancel = true;
            }
            else if (Convert.ToInt32(textBoxJMBG.Text.Substring(2, 2)) != dateTimePicker1.Value.Month)
            {
                errorProvider1.SetError(textBoxJMBG, "Mjesec nije validan!");
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                textBoxJMBG.SelectionStart = 2;
                textBoxJMBG.SelectionLength = 2;
                textBoxJMBG.SelectionColor = Color.Red;
                textBoxJMBG.SelectionBackColor = Color.Yellow;
                e.Cancel = true;
            }
            else if (Convert.ToInt32(textBoxJMBG.Text.Substring(4, 3)) != dateTimePicker1.Value.Year % 1000)
            {
                errorProvider1.SetError(textBoxJMBG, "Godina nije validna!");
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                textBoxJMBG.SelectionStart = 4;
                textBoxJMBG.SelectionLength = 3;
                textBoxJMBG.SelectionColor = Color.Red;
                textBoxJMBG.SelectionBackColor = Color.Yellow;
                e.Cancel = true;
            }
            else if (!Osoba.checksum(textBoxJMBG.Text))
            {
                errorProvider1.SetError(textBoxJMBG, "Kontrolna cifra invalid!");
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                textBoxJMBG.SelectionStart = 12;
                textBoxJMBG.SelectionLength = 1;
                textBoxJMBG.SelectionColor = Color.Red;
                textBoxJMBG.SelectionBackColor = Color.Yellow;
                e.Cancel = true;
            }
        }

        private void textBoxJMBG_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
            textBoxJMBG.BackColor = Color.White;
            textBoxJMBG.SelectionStart = textBoxJMBG.Text.Length;
            textBoxJMBG.SelectionLength = 0;
            textBoxJMBG.SelectionColor = Color.Black;
            textBoxJMBG.SelectionBackColor = Color.White;
        }

        private void textBoxJMBG_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
            textBoxJMBG.BackColor = Color.White;
            textBoxJMBG.SelectionStart = textBoxJMBG.Text.Length;
            textBoxJMBG.SelectionLength = 0;
            textBoxJMBG.SelectionColor = Color.Black;
            textBoxJMBG.SelectionBackColor = Color.White;
        }

        private void textBoxIndex_Validating(object sender, CancelEventArgs e)
        {
            if (radioButtonMaster.Checked)
            {
                string patern = @"\d{3}/\d{5}";
                Regex reg = new Regex(patern);
                if (!reg.IsMatch(textBoxIndex.Text))
                {
                    errorProvider1.SetError(textBoxIndex, "Master indeks neispravan!");
                    textBoxIndex.BackColor = Color.Red;
                    toolStripStatusLabel1.Text = "Greska!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
            }
            else if (radioButtonProfesor.Checked)
            {
                Regex reg = new Regex(@"^[0-9]+$");
                if (!reg.IsMatch(textBoxIndex.Text))
                {
                    errorProvider1.SetError(textBoxIndex, "Sifra zaposlenog neispravna!");
                    textBoxIndex.BackColor = Color.Red;
                    toolStripStatusLabel1.Text = "Greska!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
            }
            else if (radioButtonStudent.Checked)
            {
                Regex reg = new Regex(@"\d{5}$");
                if (!reg.IsMatch(textBoxIndex.Text) || textBoxIndex.Text.Length != 5)
                {
                    errorProvider1.SetError(textBoxIndex, "Broj indeksa neispravan!");
                    textBoxIndex.BackColor = Color.Red;
                    toolStripStatusLabel1.Text = "Greska!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxIndex.BackColor = Color.White;
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxIndex_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxIndex.BackColor = Color.White;
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUsername.Text.Length < 5)
            {
                errorProvider1.SetError(textBoxUsername, "Username mora sadrzavati bar 5 znakova!");
                textBoxUsername.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
            else if (!b.B.slobodanUsername(textBoxUsername.Text))
            {
                errorProvider1.SetError(textBoxUsername, "Zauzet username!");
                textBoxUsername.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxUsername.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxUsername_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxUsername.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.Text.Length < 5)
            {
                errorProvider1.SetError(textBoxPassword, "Password mora sadrzavati bar 5 znakova!");
                textBoxPassword.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPassword.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPassword.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPotvrda.Text != textBoxPassword.Text)
            {
                errorProvider1.SetError(textBoxPotvrda, "Passwordi se ne poklapaju!");
                textBoxPotvrda.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBoxPotvrda_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPotvrda.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPotvrda_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPotvrda.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string met = "";
                if (radioButtonMjesecno.Checked)
                    met = "M";
                else
                    met = "G";
                for (int i = 0; i < b.B.Clanovi.Count; i++)
                {
                    if (b.B.Clanovi[i] == c)
                    {
                        if (radioButtonMaster.Checked)
                        {
                            try
                            {
                                b.otvoriKonekciju();
                                (b.B.Clanovi[i] as MasterStudent).azuriraj(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", met, Convert.ToInt32(textBoxIndex.Text), textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika);
                                b.azurirajClana(b.B.Clanovi[i]);
                                b.zatvoriKonekciju();
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabel1.Text = ex.Message;
                            }
                        }
                        else if (radioButtonObicni.Checked)
                        {
                            try
                            {
                                b.otvoriKonekciju();
                                b.B.Clanovi[i].azuriraj(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", met, textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika);
                                b.azurirajClana(b.B.Clanovi[i]);
                                b.otvoriKonekciju();
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabel1.Text = ex.Message;
                            }
                        }
                        else if (radioButtonStudent.Checked)
                        {
                            try
                            {
                                b.otvoriKonekciju();
                                (b.B.Clanovi[i] as Student).azuriraj(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", met, Convert.ToInt32(textBoxIndex.Text), textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika);
                                b.azurirajClana(b.B.Clanovi[i]);
                                b.zatvoriKonekciju();
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabel1.Text = ex.Message;
                            }
                        }
                        else
                        {
                            try
                            {
                                b.otvoriKonekciju();
                                (b.B.Clanovi[i] as Profesor).azuriraj(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", met, Convert.ToInt32(textBoxIndex.Text), textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika);
                                b.azurirajClana(b.B.Clanovi[i]);
                                b.zatvoriKonekciju();
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabel1.Text = ex.Message;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            this.Close();
        }
    }
}
