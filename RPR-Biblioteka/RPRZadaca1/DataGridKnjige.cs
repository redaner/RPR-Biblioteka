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
    public partial class DataGridKnjige : Form
    {
        public DataGridKnjige()
        {
            InitializeComponent();
        }

        public DataGridKnjige(List<Knjiga> l)
        {
            InitializeComponent();
            BindingList<Knjiga> b = new BindingList<Knjiga>(l);
            dataGridView1.DataSource = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
