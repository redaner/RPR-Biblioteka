using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPRZadaca1
{
    public partial class UbacivanjeSlike : UserControl
    {
        public UbacivanjeSlike()
        {
            InitializeComponent();
        }

        public Image Slika
        {
            get
            {
                return pictureBoxSlika.Image;
            }
            set
            {
                pictureBoxSlika.Image = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return dateTimePicker1.Value;
            }
            set
            {
                dateTimePicker1.Value = value;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
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

        private void buttonDodaj_Click_1(object sender, EventArgs e)
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
    }
}
