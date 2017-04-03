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
    public partial class Pretraga : Form
    {
        private BibliotekaBaza b;
        public Pretraga()
        {
            InitializeComponent();
        }

        public Pretraga(BibliotekaBaza bb)
        {
            b = bb;
            InitializeComponent();
        }

        private void textBoxKnjige_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKnjige.Text == string.Empty)
            {
                listBoxKnjige.DataSource = new List<string>();
                return;
            }
            listBoxKnjige.DataSource = b.B.PretraziKnjigePoNazivu(textBoxKnjige.Text);
        }

        private void textBoxClanovi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxClanovi.Text == string.Empty)
            {
                listBoxClanovi.DataSource = new List<string>();
                return;
            }
            listBoxClanovi.DataSource = b.B.PretraziOsobePoNazivu(textBoxClanovi.Text);
        }

        private void textBoxUposleni_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUposleni.Text == string.Empty)
            {
                listBoxUposleni.DataSource = new List<string>();
                return;
            }
            listBoxUposleni.DataSource = b.B.PretraziUposlenePoNazivu(textBoxUposleni.Text);
        }
    }
}
