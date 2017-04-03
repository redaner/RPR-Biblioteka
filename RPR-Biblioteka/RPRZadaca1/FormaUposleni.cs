using RPRZadaca2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RPRZadaca1
{
    public partial class FormaUposleni : Form
    {
        private Uposleni u;
        private BibliotekaBaza b;
        public FormaUposleni()
        {
            InitializeComponent();
        }
        public FormaUposleni(Osoba o, BibliotekaBaza bb)
        {
            b = bb;
            u = o as Uposleni;
            InitializeComponent();
        }

        private void FormaUposleni_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.B.Knjige;
            foreach (Clan o in b.B.Clanovi)
            {
                treeView1.Nodes.Add(o.Sifra + " " + o.Ime + " " + o.Prezime);
            }
            listBoxBiblio.DataSource = b.B.Knjige;
            BindingList<Knjiga> bl = new BindingList<Knjiga>(b.B.uposleniIznajmljene(u.Iznajmljene_knjige));
            listBoxIznajmljene.DataSource = bl;
            dataGridView2.DataSource = new BindingSource(b.B.BrojKnjigaPoZanrovima(), null);
            dataGridView3.DataSource = new BindingSource(b.B.StrukturaCitaocaPoGodistima(), null);
            dataGridView2.Columns[0].HeaderText = "Zanr";
            dataGridView2.Columns[1].HeaderText = "Broj";
            dataGridView3.Columns[0].HeaderText = "Godiste";
            dataGridView3.Columns[1].HeaderText = "Broj";

        }

        private void buttonIznajmi_Click(object sender, EventArgs e)
        {
            try
            {
                b.otvoriKonekciju();
                b.iznajmiKnjiguUposlenom(u.Sifra, (listBoxBiblio.SelectedItem as Knjiga).Sifra_knjige);
                u = b.B.PretraziUposlenePoSifri(u.Sifra);
                listBoxIznajmljene.DataSource = b.B.uposleniIznajmljene(u.Iznajmljene_knjige);
                b.zatvoriKonekciju();
            }
            catch (Exception ex)
            {
                labelGreska.Text = ex.Message;
                labelGreska.Visible = true;
                b.zatvoriKonekciju();
            }
        }

        private void listBoxBiblio_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGreska.Visible = false;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string sifr = new string(e.Node.Text.TakeWhile(char.IsDigit).ToArray());
            int sif = Convert.ToInt32(sifr);
            Clan c = b.B.PretraziPoSifri(sif) as Clan;

            Pregled p = new Pregled(c, b);
            p.ShowDialog();
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            b.otvoriKonekciju();
            u.IzbaciKnjigu(b.B.vratiKnjiguSaSifrom((listBoxIznajmljene.SelectedItem as Knjiga).Sifra_knjige));
            b.vratiKnjigu((listBoxIznajmljene.SelectedItem as Knjiga).Sifra_knjige);
            BindingList<Knjiga> bl = new BindingList<Knjiga>(b.B.uposleniIznajmljene(u.Iznajmljene_knjige));
            listBoxIznajmljene.DataSource = bl;
            b.zatvoriKonekciju();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistracijaKnjige rk = new RegistracijaKnjige(b);
            rk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistracijaClana rc = new RegistracijaClana(b);
            rc.ShowDialog();
        }

        private void buttonKreirajXML_Click(object sender, EventArgs e)
        {
            kreirajXml();
        }

        private async void kreirajXml()
        {
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            XmlSerializer xs = new XmlSerializer(typeof(List<Knjiga>), new Type[] { typeof(Strip), typeof(NaucniRad) });
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            await Task.Run( () => xs.Serialize(fs, b.B.Knjige));
            fs.Close();
        }

        private void buttonPregledXML_Click(object sender, EventArgs e)
        {
            pregledXml();
        }

        private async void pregledXml()
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".xml")) ;
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XmlReader xr = XmlReader.Create(fs);
                    XmlSerializer xs = new XmlSerializer(typeof(List<Knjiga>), new Type[] { typeof(Strip), typeof(NaucniRad) });
                    List<Knjiga> l = new List<Knjiga>(await Task.Run( () => xs.Deserialize(xr) as List<Knjiga>));

                    if (l != null)
                    {
                        DataGridKnjige dgu = new DataGridKnjige(l);
                        dgu.ShowDialog();
                    }
                    fs.Close();
                }
            }
        }

        private void buttonKreirajBin_Click(object sender, EventArgs e)
        {
            kreirajBin();
        }

        private async void kreirajBin()
        {
            saveFileDialog1.Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            BinaryFormatter xs = new BinaryFormatter();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            await Task.Run( () => xs.Serialize(fs, b.B.Knjige));
            fs.Close();
        }

        private void buttonUcitajBin_Click(object sender, EventArgs e)
        {
            pregledBin();
        }

        private async void pregledBin()
        {
            openFileDialog1.Filter = "DAT files (*.dat)|*.dat";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".dat")) ;
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    BinaryReader xr = new BinaryReader(fs);
                    BinaryFormatter xs = new BinaryFormatter();
                    List<Knjiga> l = new List<Knjiga>(await Task.Run( () => xs.Deserialize(fs) as List<Knjiga>));

                    if (l != null)
                    {
                        DataGridKnjige dgu = new DataGridKnjige(l);
                        dgu.ShowDialog();
                    }
                    fs.Close();
                }
            }
        }
    }
}
