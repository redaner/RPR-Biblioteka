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
    public partial class Pregled : Form
    {
        Clan c;
        BibliotekaBaza b;
        public Pregled()
        {
            InitializeComponent();
        }

        public Pregled(Clan cc, BibliotekaBaza bb)
        {
            c = cc;
            b = bb;
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists && openFileDialog1.FileName.Contains(".jpg"))
            {
                pictureBoxSlika.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBoxSlika.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Profilna slika nije pravilno izabrana ili nije u ispravnom formatu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistruj_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                c.Komentar = textBox1.Text;
                b.B.PretraziPoSifri(c.Sifra).Komentar = textBox1.Text;
                this.Close();
            }
            else
            {
 
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            textBoxIme.Text = c.Ime;
            textBoxPrezime.Text = c.Prezime;
            textBoxJMBG.Text = c.Maticni_broj;
            dateTimePicker1.Value = c.Datum_rodjenja;
            if (c.Metod == metoda_placanja.mjesecno)
                radioButtonMjesecno.Checked = true;
            else
                radioButtonGodisnje.Checked = true;
            if (c is Student)
            {
                labelIndex.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = Convert.ToString((c as Student).Broj_indeksa);
                
                radioButtonStudent.Checked = true;
            }
            else if (c is MasterStudent)
            {
                labelIndex.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = Convert.ToString((c as MasterStudent).Broj_indeksa);
                
                radioButtonMaster.Checked = true;
            }
            else if (c is Profesor)
            {
                labelSifra.Visible = true;
                textBoxIndex.Visible = true;
                textBoxIndex.Text = Convert.ToString((c as Profesor).Sifra_zaposlenog);
                
                radioButtonProfesor.Checked = true;
            }
            else
                radioButtonObicni.Checked = true;
            pictureBoxSlika.Image = c.Slika;
            textBoxUsername.Text = c.Username;
        }
    }
}
