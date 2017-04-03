namespace RPRZadaca1
{
    partial class FormaUposleni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaUposleni));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelGreska = new System.Windows.Forms.Label();
            this.listBoxBiblio = new System.Windows.Forms.ListBox();
            this.buttonVrati = new System.Windows.Forms.Button();
            this.buttonIznajmi = new System.Windows.Forms.Button();
            this.listBoxIznajmljene = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKreirajXML = new System.Windows.Forms.Button();
            this.buttonPregledXML = new System.Windows.Forms.Button();
            this.buttonKreirajBin = new System.Windows.Forms.Button();
            this.buttonUcitajBin = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pregled knjiga";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj novu knjigu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(439, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelGreska);
            this.tabPage2.Controls.Add(this.listBoxBiblio);
            this.tabPage2.Controls.Add(this.buttonVrati);
            this.tabPage2.Controls.Add(this.buttonIznajmi);
            this.tabPage2.Controls.Add(this.listBoxIznajmljene);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Licno stanje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelGreska
            // 
            this.labelGreska.Location = new System.Drawing.Point(181, 71);
            this.labelGreska.Name = "labelGreska";
            this.labelGreska.Size = new System.Drawing.Size(75, 52);
            this.labelGreska.TabIndex = 4;
            this.labelGreska.Text = "nebitno";
            this.labelGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGreska.Visible = false;
            // 
            // listBoxBiblio
            // 
            this.listBoxBiblio.FormattingEnabled = true;
            this.listBoxBiblio.Location = new System.Drawing.Point(262, 71);
            this.listBoxBiblio.Name = "listBoxBiblio";
            this.listBoxBiblio.Size = new System.Drawing.Size(120, 186);
            this.listBoxBiblio.TabIndex = 3;
            this.listBoxBiblio.SelectedIndexChanged += new System.EventHandler(this.listBoxBiblio_SelectedIndexChanged);
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(181, 168);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(75, 23);
            this.buttonVrati.TabIndex = 2;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.buttonVrati_Click);
            // 
            // buttonIznajmi
            // 
            this.buttonIznajmi.Location = new System.Drawing.Point(181, 126);
            this.buttonIznajmi.Name = "buttonIznajmi";
            this.buttonIznajmi.Size = new System.Drawing.Size(75, 23);
            this.buttonIznajmi.TabIndex = 1;
            this.buttonIznajmi.Text = "Iznajmi";
            this.buttonIznajmi.UseVisualStyleBackColor = true;
            this.buttonIznajmi.Click += new System.EventHandler(this.buttonIznajmi_Click);
            // 
            // listBoxIznajmljene
            // 
            this.listBoxIznajmljene.FormattingEnabled = true;
            this.listBoxIznajmljene.Location = new System.Drawing.Point(55, 71);
            this.listBoxIznajmljene.Name = "listBoxIznajmljene";
            this.listBoxIznajmljene.Size = new System.Drawing.Size(120, 186);
            this.listBoxIznajmljene.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(439, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pregled profila";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj novog člana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(421, 269);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(439, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analiza";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Struktura citaoca po godistima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj knjiga po zanrovima:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(239, 34);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(194, 279);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(194, 279);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUcitajBin);
            this.groupBox1.Controls.Add(this.buttonKreirajBin);
            this.groupBox1.Controls.Add(this.buttonPregledXML);
            this.groupBox1.Controls.Add(this.buttonKreirajXML);
            this.groupBox1.Location = new System.Drawing.Point(6, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serijalizacija";
            // 
            // buttonKreirajXML
            // 
            this.buttonKreirajXML.Location = new System.Drawing.Point(67, 50);
            this.buttonKreirajXML.Name = "buttonKreirajXML";
            this.buttonKreirajXML.Size = new System.Drawing.Size(131, 23);
            this.buttonKreirajXML.TabIndex = 0;
            this.buttonKreirajXML.Text = "Kreiraj XML";
            this.buttonKreirajXML.UseVisualStyleBackColor = true;
            this.buttonKreirajXML.Click += new System.EventHandler(this.buttonKreirajXML_Click);
            // 
            // buttonPregledXML
            // 
            this.buttonPregledXML.Location = new System.Drawing.Point(67, 80);
            this.buttonPregledXML.Name = "buttonPregledXML";
            this.buttonPregledXML.Size = new System.Drawing.Size(131, 23);
            this.buttonPregledXML.TabIndex = 1;
            this.buttonPregledXML.Text = "Pregled XML-a";
            this.buttonPregledXML.UseVisualStyleBackColor = true;
            this.buttonPregledXML.Click += new System.EventHandler(this.buttonPregledXML_Click);
            // 
            // buttonKreirajBin
            // 
            this.buttonKreirajBin.Location = new System.Drawing.Point(224, 50);
            this.buttonKreirajBin.Name = "buttonKreirajBin";
            this.buttonKreirajBin.Size = new System.Drawing.Size(131, 23);
            this.buttonKreirajBin.TabIndex = 2;
            this.buttonKreirajBin.Text = "Kreiraj binarnu datoteku";
            this.buttonKreirajBin.UseVisualStyleBackColor = true;
            this.buttonKreirajBin.Click += new System.EventHandler(this.buttonKreirajBin_Click);
            // 
            // buttonUcitajBin
            // 
            this.buttonUcitajBin.Location = new System.Drawing.Point(224, 80);
            this.buttonUcitajBin.Name = "buttonUcitajBin";
            this.buttonUcitajBin.Size = new System.Drawing.Size(131, 23);
            this.buttonUcitajBin.TabIndex = 3;
            this.buttonUcitajBin.Text = "Učitaj iz binarne";
            this.buttonUcitajBin.UseVisualStyleBackColor = true;
            this.buttonUcitajBin.Click += new System.EventHandler(this.buttonUcitajBin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormaUposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 344);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaUposleni";
            this.Text = "FormaUposleni";
            this.Load += new System.EventHandler(this.FormaUposleni_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxBiblio;
        private System.Windows.Forms.Button buttonVrati;
        private System.Windows.Forms.Button buttonIznajmi;
        private System.Windows.Forms.ListBox listBoxIznajmljene;
        private System.Windows.Forms.Label labelGreska;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUcitajBin;
        private System.Windows.Forms.Button buttonKreirajBin;
        private System.Windows.Forms.Button buttonPregledXML;
        private System.Windows.Forms.Button buttonKreirajXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}