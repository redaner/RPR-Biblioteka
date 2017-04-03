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
    public partial class RegistracijaKnjige : Form
    {
        Knjiga k;
        private BibliotekaBaza b;
        public RegistracijaKnjige()
        {
            InitializeComponent();
        }

        public RegistracijaKnjige(BibliotekaBaza bb)
        {
            b = bb;
            InitializeComponent();
        }

        public RegistracijaKnjige(BibliotekaBaza bb, Knjiga kk)
        {
            b = bb;
            k = kk;
            InitializeComponent();
            textBoxNaslov.Text = k.Naslov_knjige;
            listBoxAutori.DataSource = k.Spisak_autora;
            textBoxISBN.Text = k.ISBN;
            comboBox1.Text = k.Zanr;
            textBoxIzdavac.Text = k.Naziv_izdavaca;
            numericUpDown1.Value = k.Godina_izdanja;
            if (k is Strip)
                radioButtonStrip.Checked = true;
            else if (k is NaucniRad)
                radioButtonNaucni.Checked = true;
            else
                radioButtonObicna.Checked = true;
            groupBox1.Enabled = false;
            labelDodajUmj.Visible = false;
            labelIzdanje.Visible = false;
            labelKuca.Visible = false;
            labelOblast.Visible = false;
            labelUmjetnici.Visible = false;
            labelKonferencija.Visible = false;
            textBoxKonferencija.Visible = false;
            textBoxKuca.Visible = false;
            listBox1.Visible = false;
            numericUpDown2.Visible = false;
            labelIzdanje.Visible = false;
            groupBox2.Visible = false;
            buttonRegistruj.Visible = false;
            button1.Visible = true;
        }

        private void radioButtonStrip_CheckedChanged(object sender, EventArgs e)
        {
            buttonDodajUmj.Visible = true;
            labelOblast.Visible = false;
            labelKonferencija.Visible = false;
            textBoxKonferencija.Visible = false;
            labelKuca.Visible = true;
            textBoxKuca.Visible = true;
            labelUmjetnici.Visible = true;
            labelDodajUmj.Visible = true;
            listBox1.Visible = true;
            textBoxDodajUmj.Visible = true;
            labelIzdanje.Visible = true;
            numericUpDown2.Visible = true;
            groupBox2.Visible = true;
        }

        private void radioButtonNaucni_CheckedChanged(object sender, EventArgs e)
        {
            
            buttonDodajUmj.Visible = false;
            labelKuca.Visible = false;
            labelUmjetnici.Visible = false;
            labelDodajUmj.Visible = false;
            listBox1.Visible = false;
            textBoxDodajUmj.Visible = false;
            labelIzdanje.Visible = false;
            numericUpDown2.Visible = false;
            groupBox2.Visible = false;
            labelOblast.Visible = true;
            textBoxKuca.Visible = true;
            labelKonferencija.Visible = true;
            textBoxKonferencija.Visible = true;
        }

        private void radioButtonObicna_CheckedChanged(object sender, EventArgs e)
        {
            buttonDodajUmj.Visible = false;
            textBoxKuca.Visible = false;
            labelKuca.Visible = false;
            labelUmjetnici.Visible = false;
            labelDodajUmj.Visible = false;
            listBox1.Visible = false;
            textBoxDodajUmj.Visible = false;
            labelIzdanje.Visible = false;
            numericUpDown2.Visible = false;
            groupBox2.Visible = false;
            labelOblast.Visible = false;
            labelKonferencija.Visible = false;
            textBoxKonferencija.Visible = false;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            listBoxAutori.Items.Add(textBoxDodaj.Text);
            textBoxDodaj.Text = string.Empty;
            textBoxDodaj.Focus();
        }

        private void buttonDodajUmj_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxDodajUmj.Text);
            textBoxDodajUmj.Text = string.Empty;
            textBoxDodajUmj.Focus();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistruj_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                List<string> l = listBoxAutori.Items.Cast<string>().ToList();
                if (radioButtonObicna.Checked)
                {
                    b.otvoriKonekciju();
                    b.dodajKnjigu(new RPRZadaca1.Knjiga(textBoxNaslov.Text, l, textBoxISBN.Text, comboBox1.Text, textBoxIzdavac.Text, Convert.ToInt32(numericUpDown1.Value)));
                    b.zatvoriKonekciju();
                }
                else if (radioButtonNaucni.Checked)
                {
                    b.otvoriKonekciju();
                    b.dodajKnjigu(new RPRZadaca1.NaucniRad(textBoxNaslov.Text, l, textBoxISBN.Text, comboBox1.Text, textBoxIzdavac.Text, Convert.ToInt32(numericUpDown1.Value), textBoxKonferencija.Text, textBoxKuca.Text));
                    b.zatvoriKonekciju();
                }
                else
                {
                    bool spec = false;
                    if (radioButtonSpecijalno.Checked) spec = true;
                    List<string> l2 = listBox1.Items.Cast<string>().ToList();
                    b.otvoriKonekciju();
                    b.dodajKnjigu(new RPRZadaca1.Strip(textBoxNaslov.Text, l, textBoxISBN.Text, comboBox1.Text, textBoxIzdavac.Text, Convert.ToInt32(numericUpDown1.Value), textBoxKuca.Text, l2, Convert.ToInt32(numericUpDown2.Value), spec));
                    b.zatvoriKonekciju();
                }
                this.Close();
            }
        }
          catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
        }

        private void RegistracijaKnjige_Load(object sender, EventArgs e)
        {
            List<string> zanrovi = new List<string>();
            zanrovi.Add("Drama");
            zanrovi.Add("Sci-Fi");
            zanrovi.Add("Komedija");
            zanrovi.Add("Tragedija");
            zanrovi.Add("Romansa");
            zanrovi.Add("Horor");
            zanrovi.Add("Akcija");
            zanrovi.Add("Triler");
            zanrovi.Add("Fantazija");
            zanrovi.Add("Avantura");
            comboBox1.DataSource = zanrovi;
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxISBN_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"(ISBN[-]*(1[03])*[ ]*(: ){0,1})*(([0-9Xx][- ]*){13}|([0-9Xx][- ]*){10})$");
            if (!r.IsMatch(textBoxISBN.Text))
            {
                errorProvider1.SetError(textBoxISBN, "Nevalidan ISBN.");
                textBoxISBN.BackColor = Color.Red;
                toolStripStatusLabel1.Text = "Greska!";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxISBN.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void textBoxISBN_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBoxISBN.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.B.Knjige.Count; i++)
            {
                if (b.B.Knjige[i] == k)
                {
                    b.otvoriKonekciju();
                    b.B.Knjige[i].azuriraj(textBoxNaslov.Text, listBoxAutori.Items.Cast<string>().ToList<string>(), textBoxISBN.Text, comboBox1.Text, textBoxIzdavac.Text, Convert.ToInt32(numericUpDown1.Value));
                    b.azurirajKnjigu(b.B.Knjige[i]);
                    b.zatvoriKonekciju();
                }
            }
            this.Close();
        }
    }
}
