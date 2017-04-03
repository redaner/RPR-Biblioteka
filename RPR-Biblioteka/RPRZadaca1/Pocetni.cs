using RPRZadaca2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPRZadaca1
{
    public partial class Pocetni : Form
    {
        private BibliotekaBaza b;
        bool aktivna;
     
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

        public Pocetni()
        {
           
            InitializeComponent();
        }

        public Pocetni(Biblioteka b1)
        {
            aktivna = true;
            b = new BibliotekaBaza();
            Thread t1 = new Thread(new ThreadStart( b.otvoriKonekciju));
            t1.Start();
            t1.Join();
            Thread t2 = new Thread(new ThreadStart(b.ucitajBazu));
            t2.Start();
            t2.Join();
            Thread t3 = new Thread( () =>b.zatvoriKonekciju());
            InitializeComponent();
            
        }

        void crna()
        {
            while (aktivna)
            {
                Graphics g = CreateGraphics();
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                Rectangle r = new Rectangle(new Point(15, 10), new Size(160, 280));
                Pen pen = new Pen(Color.Yellow, 10);
                g.DrawRectangle(pen, r);
                Point[] p = new Point[] { new Point(50, 84), new Point(160, 84), new Point(160, 250) };
                Point[] p1 = new Point[] { new Point(30, 110), new Point(30, 280), new Point(120, 280) };
                SolidBrush sb = new SolidBrush(Color.Black);
                SolidBrush sb1 = new SolidBrush(Color.BlueViolet);
                g.FillPolygon(sb1, p1);
                g.FillPolygon(sb1, p);
                g.DrawString("ETF", new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold), sb, new Point(20, 10));
                g.DrawString("L", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(30, 80));
                g.DrawString("I", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(50, 110));
                g.DrawString("B", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(60, 140));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(80, 170));
                g.DrawString("A", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(100, 200));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(120, 230));
                g.DrawString("Y", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(140, 260));
                Thread.Sleep(2000);
            }
        }

        void zuta()
        {
            while (aktivna)
            {
                Graphics g = CreateGraphics();
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                Rectangle r = new Rectangle(new Point(15, 10), new Size(160, 280));
                Pen pen = new Pen(Color.Yellow, 10);
                g.DrawRectangle(pen, r);
                Point[] p = new Point[] { new Point(50, 84), new Point(160, 84), new Point(160, 250) };
                Point[] p1 = new Point[] { new Point(30, 110), new Point(30, 280), new Point(120, 280) };
                SolidBrush sb = new SolidBrush(Color.Red);
                SolidBrush sb1 = new SolidBrush(Color.BlueViolet);
                g.FillPolygon(sb1, p1);
                g.FillPolygon(sb1, p);
                g.DrawString("ETF", new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold), sb, new Point(20, 10));
                g.DrawString("L", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(30, 80));
                g.DrawString("I", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(50, 110));
                g.DrawString("B", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(60, 140));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(80, 170));
                g.DrawString("A", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(100, 200));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(120, 230));
                g.DrawString("Y", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(140, 260));
                Thread.Sleep(500);
            }
        }

        void crvena()
        {
            while (aktivna)
            {
                Graphics g = CreateGraphics();
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                Rectangle r = new Rectangle(new Point(15, 10), new Size(160, 280));
                Pen pen = new Pen(Color.Black, 10);
                g.DrawRectangle(pen, r);
                Point[] p = new Point[] { new Point(50, 84), new Point(160, 84), new Point(160, 250) };
                Point[] p1 = new Point[] { new Point(30, 110), new Point(30, 280), new Point(120, 280) };
                SolidBrush sb = new SolidBrush(Color.Red);
                SolidBrush sb1 = new SolidBrush(Color.BlueViolet);
                g.FillPolygon(sb1, p1);
                g.FillPolygon(sb1, p);
                g.DrawString("ETF", new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold), sb, new Point(20, 10));
                g.DrawString("L", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(30, 80));
                g.DrawString("I", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(50, 110));
                g.DrawString("B", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(60, 140));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(80, 170));
                g.DrawString("A", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(100, 200));
                g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(120, 230));
                g.DrawString("Y", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(140, 260));
                Thread.Sleep(1000);
            }
        }

        private void plava()
        {
            Graphics g = CreateGraphics();
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            Rectangle r = new Rectangle(new Point(15, 10), new Size(160, 280));
            Pen pen = new Pen(Color.Yellow, 10);
            g.DrawRectangle(pen, r);
            Point[] p = new Point[] { new Point(50, 84), new Point(160, 84), new Point(160, 250) };
            Point[] p1 = new Point[] { new Point(30, 110), new Point(30, 280), new Point(120, 280) };
            SolidBrush sb = new SolidBrush(Color.Black);
            SolidBrush sb1 = new SolidBrush(Color.BlueViolet);
            g.FillPolygon(sb1, p1);
            g.FillPolygon(sb1, p);
            g.DrawString("ETF", new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold), sb, new Point(20, 10));
            g.DrawString("L", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(30, 80));
            g.DrawString("I", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(50, 110));
            g.DrawString("B", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(60, 140));
            g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(80, 170));
            g.DrawString("A", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(100, 200));
            g.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(120, 230));
            g.DrawString("Y", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(140, 260));
        }

        private void Pocetni_Paint(object sender, PaintEventArgs e)
        {
           /* Thread t = new Thread
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            Rectangle r = new Rectangle(new Point(15, 10), new Size(160, 280));
            Pen pen = new Pen(Color.Yellow, 10);
            e.Graphics.DrawRectangle(pen, r);
            Point[] p = new Point[] { new Point(50, 84), new Point(160, 84), new Point(160, 250) };
            Point[] p1 = new Point[] { new Point(30, 110), new Point(30, 280), new Point(120, 280) };
            SolidBrush sb = new SolidBrush(Color.Black);
            SolidBrush sb1 = new SolidBrush(Color.BlueViolet);
            e.Graphics.FillPolygon(sb1, p1);
            e.Graphics.FillPolygon(sb1, p);
            e.Graphics.DrawString("ETF", new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold), sb, new Point(20, 10));
            e.Graphics.DrawString("L", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(30, 80));
            e.Graphics.DrawString("I", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(50, 110));
            e.Graphics.DrawString("B", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(60, 140));
            e.Graphics.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(80, 170));
            e.Graphics.DrawString("A", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(100, 200));
            e.Graphics.DrawString("R", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(120, 230));
            e.Graphics.DrawString("Y", new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Underline), sb, new Point(140, 260));*/

        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Admin a = new Admin(B);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    if (B.B.nadjiUsername(textBoxUsername.Text) is Student || B.B.nadjiUsername(textBoxUsername.Text) is MasterStudent
                        || B.B.nadjiUsername(textBoxUsername.Text) is Profesor || B.B.nadjiUsername(textBoxUsername.Text) is Clan || B.B.nadjiUsername(textBoxUsername.Text) is Uposleni)
                    {
                        labelNepostojeca.Visible = false;
                        try
                        {
                            if (B.B.nadjiUsername(textBoxUsername.Text).verifyMd5Hash(textBoxPassword.Text))
                            {
                                if (B.B.nadjiUsername(textBoxUsername.Text) is Uposleni)
                                {
                                    FormaUposleni fu = new FormaUposleni(B.B.nadjiUsername(textBoxUsername.Text),  B);
                                    fu.ShowDialog();

                                }
                                else
                                {
                                    FormaClan fc = new FormaClan(B.B.nadjiUsername(textBoxUsername.Text) as Clan,  B);
                                    fc.ShowDialog();
                                }
                                labelPogresna.Visible = false;
                                return;
                            }
                            throw new Exception();
                        }
                        catch (Exception ex)
                        {
                            labelPogresna.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    labelNepostojeca.Visible = true;
                }
            }
        }

        private void Pocetni_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Broj knjiga po zanrovima: ");

            Dictionary<string, int> d = new Dictionary<string, int>(B.B.BrojKnjigaPoZanrovima());
            foreach(KeyValuePair<string, int> k in d)
            {
                chart1.Series.Add(k.Key);
                chart1.Series[k.Key].Points.Add(k.Value);
            }

            Thread t1 = new Thread(new ThreadStart(crna));
            Thread t2 = new Thread(new ThreadStart(crvena));
            Thread t3 = new Thread(new ThreadStart(zuta));
            Thread t4 = new Thread(new ThreadStart(plava));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }

        private void Pocetni_Enter(object sender, EventArgs e)
        {
            
        }

        private void Pocetni_MouseEnter(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Dictionary<string, int> d = new Dictionary<string, int>(B.B.BrojKnjigaPoZanrovima());
            foreach (KeyValuePair<string, int> k in d)
            {
                chart1.Series.Add(k.Key);
                chart1.Series[k.Key].Points.Add(k.Value);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pretraga p = new Pretraga(B);
            p.ShowDialog();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void Pocetni_Leave(object sender, EventArgs e)
        {
            aktivna = false;
        }
    }
}
