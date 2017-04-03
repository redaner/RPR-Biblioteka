using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using RPRZadaca2;

namespace RPRZadaca1
{
    public partial class RegistracijaUposlenog : Form
    {
        Uposleni u;
        private BibliotekaBaza b;
        public RegistracijaUposlenog()
        {
            InitializeComponent();
        }

        public RegistracijaUposlenog(BibliotekaBaza bb)
        {
            b = bb;
            InitializeComponent();
        }

        public RegistracijaUposlenog(BibliotekaBaza bb, Uposleni uu)
        {
            u = uu;
            b = bb;
            InitializeComponent();
            textBoxIme.Text = u.Ime;
            textBoxPrezime.Text = u.Prezime;
            dateTimePicker1.Value = u.Datum_rodjenja;
            textBoxJMBG.Text = u.Maticni_broj;
            textBoxUsername.Text = u.Username;
            textBoxPassword.Text = u.Password;
            textBoxPotvrda.Text = u.Password;
            button2.Visible = false;
            button3.Visible = true;
            ubacivanjeSlike1.Slika = u.Slika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    b.otvoriKonekciju();

                    b.dodajUposlenika(new Uposleni(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika));
                    b.zatvoriKonekciju();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
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

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxPassword.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.B.Uposlenici.Count; i++)
            {
                if (b.B.Uposlenici[i] == u)
                {
                    b.otvoriKonekciju();
                    b.B.Uposlenici[i].azuriraj(textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, dateTimePicker1.Value.Date, "", textBoxUsername.Text, textBoxPassword.Text, ubacivanjeSlike1.Slika);
                    b.azurirajUposlenika(b.B.Uposlenici[i]);
                    b.zatvoriKonekciju();
                }
            }
            this.Close();
        }
    }
}
