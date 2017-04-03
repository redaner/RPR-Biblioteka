using RPRZadaca2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPRZadaca1
{
    public partial class FormaClan : Form
    {
        private Clan vlasnik;
        private BibliotekaBaza b;
        public FormaClan()
        {
            InitializeComponent();
        }

        public FormaClan(Clan o, BibliotekaBaza bb)
        {
            vlasnik = o;
            b = bb;
            InitializeComponent();
        }

        private void FormaClan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(b.B.clanVracanjeKnjiga(vlasnik.Iznajmljene_knjige), null);
            dataGridView1.Columns[0].HeaderText = "Knjiga";
            dataGridView1.Columns[1].HeaderText = "Vracanje knjige (broj dana) ";
            listBoxBiblio.DataSource = b.B.Knjige;
            listBoxSve.DataSource = b.B.Knjige;
            labelIme.Text = vlasnik.Ime;
            foreach(int k in vlasnik.Lista_zelja)
            {
                checkedListBoxLista.Items.Add(b.B.vratiKnjiguSaSifrom(k));
            }
            dataGridView2.DataSource = new BindingSource(b.B.clanBrojKnjigaPoZanrovima(vlasnik.Iznajmljene_knjige), null);
            dataGridView3.DataSource = new BindingSource(b.B.clanBrojKnjigaPoStoljecima(vlasnik.Iznajmljene_knjige), null);
            dataGridView2.Columns[0].HeaderText = "Zanr";
            dataGridView2.Columns[1].HeaderText = "Broj";
            dataGridView3.Columns[0].HeaderText = "Stoljece";
            dataGridView3.Columns[1].HeaderText = "Broj";
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            checkedListBoxLista.Items.Add(listBoxSve.SelectedItem);
            vlasnik.Lista_zelja.Add((listBoxSve.SelectedValue as Knjiga).Sifra_knjige);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(b.B.clanVracanjeKnjiga(vlasnik.Iznajmljene_knjige), null);
            dataGridView1.Columns[0].HeaderText = "Knjiga";
            dataGridView1.Columns[1].HeaderText = "Vracanje knjige (broj dana) ";
            listBoxBiblio.DataSource = b.B.Knjige;
        }

        private void buttonIznamji_Click(object sender, EventArgs e)
        {
           // try
            //{
                b.otvoriKonekciju();
                b.iznajmiKnjiguClanu(vlasnik.Sifra, (listBoxBiblio.SelectedItem as Knjiga).Sifra_knjige);
                vlasnik = b.B.PretraziPoSifri(vlasnik.Sifra) as Clan;
                dataGridView1.DataSource = new BindingSource(b.B.clanVracanjeKnjiga(vlasnik.Iznajmljene_knjige), null);
                dataGridView1.Columns[0].HeaderText = "Knjiga";
                dataGridView1.Columns[1].HeaderText = "Vracanje knjige (broj dana) ";
                b.zatvoriKonekciju();
           // }
           /* catch (Exception ex)
            {
                labelPoruka.Text = ex.Message;
                labelPoruka.Visible = true;
            }*/
        }

        private void listBoxBiblio_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPoruka.Visible = false;
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            b.otvoriKonekciju();
            b.vratiKnjigu((dataGridView1.SelectedCells[0].Value as Knjiga).Sifra_knjige);
            dataGridView1.DataSource = b.B.clanVracanjeKnjiga(vlasnik.Iznajmljene_knjige);
            b.zatvoriKonekciju();
           /* for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.Rows[i];
                if (dr.Selected)
                    dataGridView1.Rows.RemoveAt(i);
            }*/
        }

        

        
    }
}
