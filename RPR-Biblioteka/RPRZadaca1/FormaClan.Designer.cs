namespace RPRZadaca1
{
    partial class FormaClan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaClan));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.listBoxBiblio = new System.Windows.Forms.ListBox();
            this.labelBiblioteka = new System.Windows.Forms.Label();
            this.buttonVrati = new System.Windows.Forms.Button();
            this.buttonIznamji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelIznajmljene = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelDobrodosli = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxSve = new System.Windows.Forms.ListBox();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.checkedListBoxLista = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPoruka);
            this.tabPage1.Controls.Add(this.listBoxBiblio);
            this.tabPage1.Controls.Add(this.labelBiblioteka);
            this.tabPage1.Controls.Add(this.buttonVrati);
            this.tabPage1.Controls.Add(this.buttonIznamji);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.labelIznajmljene);
            this.tabPage1.Controls.Add(this.labelIme);
            this.tabPage1.Controls.Add(this.labelDobrodosli);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pocetna";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelPoruka
            // 
            this.labelPoruka.Location = new System.Drawing.Point(195, 109);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(75, 66);
            this.labelPoruka.TabIndex = 11;
            this.labelPoruka.Text = "text";
            this.labelPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPoruka.Visible = false;
            // 
            // listBoxBiblio
            // 
            this.listBoxBiblio.FormattingEnabled = true;
            this.listBoxBiblio.Location = new System.Drawing.Point(276, 109);
            this.listBoxBiblio.Name = "listBoxBiblio";
            this.listBoxBiblio.Size = new System.Drawing.Size(181, 212);
            this.listBoxBiblio.TabIndex = 10;
            this.listBoxBiblio.SelectedIndexChanged += new System.EventHandler(this.listBoxBiblio_SelectedIndexChanged);
            // 
            // labelBiblioteka
            // 
            this.labelBiblioteka.AutoSize = true;
            this.labelBiblioteka.Location = new System.Drawing.Point(330, 93);
            this.labelBiblioteka.Name = "labelBiblioteka";
            this.labelBiblioteka.Size = new System.Drawing.Size(53, 13);
            this.labelBiblioteka.TabIndex = 9;
            this.labelBiblioteka.Text = "Biblioteka";
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(195, 207);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(75, 23);
            this.buttonVrati.TabIndex = 7;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.buttonVrati_Click);
            // 
            // buttonIznamji
            // 
            this.buttonIznamji.Location = new System.Drawing.Point(195, 178);
            this.buttonIznamji.Name = "buttonIznamji";
            this.buttonIznamji.Size = new System.Drawing.Size(75, 23);
            this.buttonIznamji.TabIndex = 6;
            this.buttonIznamji.Text = "Iznajmi";
            this.buttonIznamji.UseVisualStyleBackColor = true;
            this.buttonIznamji.Click += new System.EventHandler(this.buttonIznamji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(180, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelIznajmljene
            // 
            this.labelIznajmljene.AutoSize = true;
            this.labelIznajmljene.Location = new System.Drawing.Point(9, 93);
            this.labelIznajmljene.Name = "labelIznajmljene";
            this.labelIznajmljene.Size = new System.Drawing.Size(90, 13);
            this.labelIznajmljene.TabIndex = 3;
            this.labelIznajmljene.Text = "Iznajmljene knjige";
            // 
            // labelIme
            // 
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIme.Location = new System.Drawing.Point(135, 35);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(206, 32);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "text";
            this.labelIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDobrodosli
            // 
            this.labelDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDobrodosli.Location = new System.Drawing.Point(124, 3);
            this.labelDobrodosli.Name = "labelDobrodosli";
            this.labelDobrodosli.Size = new System.Drawing.Size(228, 32);
            this.labelDobrodosli.TabIndex = 0;
            this.labelDobrodosli.Text = "DOBRODOŠLI";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxSve);
            this.tabPage2.Controls.Add(this.buttonUkloni);
            this.tabPage2.Controls.Add(this.buttonDodaj);
            this.tabPage2.Controls.Add(this.checkedListBoxLista);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista zelja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxSve
            // 
            this.listBoxSve.FormattingEnabled = true;
            this.listBoxSve.Location = new System.Drawing.Point(310, 61);
            this.listBoxSve.Name = "listBoxSve";
            this.listBoxSve.Size = new System.Drawing.Size(130, 212);
            this.listBoxSve.TabIndex = 3;
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.Location = new System.Drawing.Point(205, 169);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(75, 23);
            this.buttonUkloni.TabIndex = 2;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(205, 123);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // checkedListBoxLista
            // 
            this.checkedListBoxLista.FormattingEnabled = true;
            this.checkedListBoxLista.Location = new System.Drawing.Point(42, 61);
            this.checkedListBoxLista.Name = "checkedListBoxLista";
            this.checkedListBoxLista.Size = new System.Drawing.Size(130, 214);
            this.checkedListBoxLista.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(466, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Analiza";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(205, 293);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj knjiga po zanrovima:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(252, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(205, 293);
            this.dataGridView3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj knjiga po stoljecima:";
            // 
            // FormaClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 358);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaClan";
            this.Text = "FormaClan";
            this.Load += new System.EventHandler(this.FormaClan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelDobrodosli;
        private System.Windows.Forms.Label labelIznajmljene;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox checkedListBoxLista;
        private System.Windows.Forms.ListBox listBoxSve;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelBiblioteka;
        private System.Windows.Forms.Button buttonVrati;
        private System.Windows.Forms.Button buttonIznamji;
        private System.Windows.Forms.ListBox listBoxBiblio;
        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}