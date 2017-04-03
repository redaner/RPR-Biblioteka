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
    public partial class Stanje : Form
    {
        BindingList<Knjiga> bl1;
        BindingList<Clan> bl2;
        BindingList<Uposleni> bl3;
        BibliotekaBaza b;
        public Stanje()
        {
            InitializeComponent();
        }

        public Stanje(BibliotekaBaza bb)
        {
            b = bb;
            InitializeComponent();
        }

        private void Stanje_Load(object sender, EventArgs e)
        {
            bl1 = new BindingList<Knjiga>(b.B.Knjige);
            dataGridView1.DataSource = bl1;
            bl2 = new BindingList<Clan>(b.B.Clanovi);
            dataGridView2.DataSource = bl2;
            bl3 = new BindingList<Uposleni>(b.B.Uposlenici);
            dataGridView3.DataSource = bl3;
        }

        private void brišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int sif = Convert.ToInt32(selectedRow.Cells["Sifra_knjige"].Value);
                for (int i = 0; i < bl1.Count; i++)
                    if (bl1[i].Sifra_knjige == sif)
                    {
                        b.otvoriKonekciju();
                        b.brisiKnjigu(sif);
                        dataGridView1.DataSource = b.B.Knjige;
                        b.zatvoriKonekciju();
                    }
            }
        }

        private void meniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                int sif = Convert.ToInt32(selectedRow.Cells["Sifra"].Value);
                for (int i = 0; i < bl2.Count; i++)
                {
                    if (bl2[i].Sifra == sif)
                    {
                        b.otvoriKonekciju();
                        b.brisiClana(sif);
                        dataGridView2.DataSource = b.B.Clanovi;
                        b.zatvoriKonekciju();
                    }
                }
            }
        }

        private void brišiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li ste sigurni?", "Poruka", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                int sif = Convert.ToInt32(selectedRow.Cells["Sifra"].Value);
                for (int i = 0; i < bl3.Count; i++)
                {
                    if (bl3[i].Sifra == sif)
                    {
                        b.otvoriKonekciju();
                        b.brisiUposlenog(sif);
                        dataGridView3.DataSource = b.B.Uposlenici;
                        b.zatvoriKonekciju();
                    }
                }
            }
        }
    }
}
