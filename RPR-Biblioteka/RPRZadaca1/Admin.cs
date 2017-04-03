using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using RPRZadaca2;
using System.Runtime.Serialization.Formatters.Binary;

namespace RPRZadaca1
{
    public partial class Admin : Form
    {
        BibliotekaBaza b;

        public BibliotekaBaza B
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

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(BibliotekaBaza bb)
        {
            B = bb;
            InitializeComponent();
        }

        private void članToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaClana rc = new RegistracijaClana(B);
            rc.ShowDialog();
        }

        private void uposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaUposlenog ru = new RegistracijaUposlenog(B);
            ru.ShowDialog();
        }

        private void knjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaKnjige rk = new RegistracijaKnjige(B);
            rk.ShowDialog();
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stanje s = new Stanje(B);
            s.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = B.B.Clanovi;
            listBox2.DataSource = B.B.Uposlenici;
            listBox3.DataSource = B.B.Knjige;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < B.B.Clanovi.Count; i++)
            {
                if (B.B.Clanovi[i] == listBox1.SelectedItem)
                {
                    RegistracijaClana rc = new RegistracijaClana(B, listBox1.SelectedItem as Clan);
                    rc.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < B.B.Uposlenici.Count; i++)
            {
                if (B.B.Uposlenici[i] == listBox2.SelectedItem)
                {
                    RegistracijaUposlenog rc = new RegistracijaUposlenog(B, listBox2.SelectedItem as Uposleni);
                    rc.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < B.B.Knjige.Count; i++)
            {
                if (B.B.Knjige[i] == listBox3.SelectedItem)
                {
                    RegistracijaKnjige rc = new RegistracijaKnjige(B, listBox3.SelectedItem as Knjiga);
                    rc.ShowDialog();
                }
            }
        }



        private void kreirajDatotekuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kreirajXML();
        }

        private async void kreirajXML()
        {
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            XmlSerializer xs = new XmlSerializer(typeof(List<Uposleni>));
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            await Task.Run( () => xs.Serialize(fs, B.B.Uposlenici));
            fs.Close();
        }

        private void pregledDatotekeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pregledXML();
        }

        private async void pregledXML()
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".xml")) ;
            {

                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XmlReader xr = XmlReader.Create(fs);
                    XmlSerializer xs = new XmlSerializer(typeof(List<Uposleni>));
                    List<Uposleni> l = new List<Uposleni>(await Task.Run(() => xs.Deserialize(xr)) as List<Uposleni>);

                    if (l != null)
                    {
                        DataGridUposleni dgu = new DataGridUposleni(l);
                        dgu.ShowDialog();
                    }
                    fs.Close();
                }
            }
        }

        private void kreirajDatotekuToolStripMenuItem2_Click(object sender, EventArgs e)
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
            await Task.Run( () => xs.Serialize(fs, B.B.Uposlenici));
            fs.Close();
        }

        private void pregledDatotekeToolStripMenuItem2_Click(object sender, EventArgs e)
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
                    List<Uposleni> l = new List<Uposleni>(await Task.Run( () => xs.Deserialize(fs) as List<Uposleni>));

                    if (l != null)
                    {
                        DataGridUposleni dgu = new DataGridUposleni(l);
                        dgu.ShowDialog();
                    }
                    fs.Close();
                }
            }
        }
    }
}
