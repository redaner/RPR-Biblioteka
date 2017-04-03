using RPRZadaca1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPRZadaca2
{
    public partial class DataGridUposleni : Form
    {
        public DataGridUposleni()
        {
            InitializeComponent();
        }

        public DataGridUposleni(List<Uposleni> l)
        {
            InitializeComponent();
            BindingList<Uposleni> b = new BindingList<Uposleni>(l);
            dataGridView1.DataSource = b;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
