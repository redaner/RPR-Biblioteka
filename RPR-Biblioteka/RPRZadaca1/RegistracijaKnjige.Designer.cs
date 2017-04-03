namespace RPRZadaca1
{
    partial class RegistracijaKnjige
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaKnjige));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.labelAutori = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelZanr = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelIzdavac = new System.Windows.Forms.Label();
            this.textBoxIzdavac = new System.Windows.Forms.TextBox();
            this.labelGodina = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNaucni = new System.Windows.Forms.RadioButton();
            this.radioButtonStrip = new System.Windows.Forms.RadioButton();
            this.radioButtonObicna = new System.Windows.Forms.RadioButton();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonRegistruj = new System.Windows.Forms.Button();
            this.labelKuca = new System.Windows.Forms.Label();
            this.textBoxKuca = new System.Windows.Forms.TextBox();
            this.labelUmjetnici = new System.Windows.Forms.Label();
            this.labelIzdanje = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSpecijalno = new System.Windows.Forms.RadioButton();
            this.radioButtonObicno = new System.Windows.Forms.RadioButton();
            this.labelOblast = new System.Windows.Forms.Label();
            this.labelKonferencija = new System.Windows.Forms.Label();
            this.textBoxKonferencija = new System.Windows.Forms.TextBox();
            this.listBoxAutori = new System.Windows.Forms.ListBox();
            this.textBoxDodaj = new System.Windows.Forms.TextBox();
            this.labelDodaj = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxDodajUmj = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelDodajUmj = new System.Windows.Forms.Label();
            this.buttonDodajUmj = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(12, 9);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(74, 13);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Naslov knjige:";
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(18, 25);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(168, 20);
            this.textBoxNaslov.TabIndex = 1;
            // 
            // labelAutori
            // 
            this.labelAutori.AutoSize = true;
            this.labelAutori.Location = new System.Drawing.Point(15, 112);
            this.labelAutori.Name = "labelAutori";
            this.labelAutori.Size = new System.Drawing.Size(68, 13);
            this.labelAutori.TabIndex = 2;
            this.labelAutori.Text = "Autori knjige:";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(15, 204);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(57, 13);
            this.labelISBN.TabIndex = 4;
            this.labelISBN.Text = "ISBN sifra:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(18, 221);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(168, 20);
            this.textBoxISBN.TabIndex = 5;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            this.textBoxISBN.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxISBN_Validating);
            this.textBoxISBN.Validated += new System.EventHandler(this.textBoxISBN_Validated);
            // 
            // labelZanr
            // 
            this.labelZanr.AutoSize = true;
            this.labelZanr.Location = new System.Drawing.Point(15, 244);
            this.labelZanr.Name = "labelZanr";
            this.labelZanr.Size = new System.Drawing.Size(32, 13);
            this.labelZanr.TabIndex = 6;
            this.labelZanr.Text = "Zanr:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // labelIzdavac
            // 
            this.labelIzdavac.AutoSize = true;
            this.labelIzdavac.Location = new System.Drawing.Point(15, 285);
            this.labelIzdavac.Name = "labelIzdavac";
            this.labelIzdavac.Size = new System.Drawing.Size(83, 13);
            this.labelIzdavac.TabIndex = 8;
            this.labelIzdavac.Text = "Naziv izdavaca:";
            // 
            // textBoxIzdavac
            // 
            this.textBoxIzdavac.Location = new System.Drawing.Point(18, 301);
            this.textBoxIzdavac.Name = "textBoxIzdavac";
            this.textBoxIzdavac.Size = new System.Drawing.Size(168, 20);
            this.textBoxIzdavac.TabIndex = 9;
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.Location = new System.Drawing.Point(15, 324);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(80, 13);
            this.labelGodina.TabIndex = 10;
            this.labelGodina.Text = "Godina izdanja:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 340);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNaucni);
            this.groupBox1.Controls.Add(this.radioButtonStrip);
            this.groupBox1.Controls.Add(this.radioButtonObicna);
            this.groupBox1.Location = new System.Drawing.Point(304, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 113);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta knjige";
            // 
            // radioButtonNaucni
            // 
            this.radioButtonNaucni.AutoSize = true;
            this.radioButtonNaucni.Location = new System.Drawing.Point(18, 90);
            this.radioButtonNaucni.Name = "radioButtonNaucni";
            this.radioButtonNaucni.Size = new System.Drawing.Size(77, 17);
            this.radioButtonNaucni.TabIndex = 2;
            this.radioButtonNaucni.TabStop = true;
            this.radioButtonNaucni.Text = "Naucni rad";
            this.radioButtonNaucni.UseVisualStyleBackColor = true;
            this.radioButtonNaucni.CheckedChanged += new System.EventHandler(this.radioButtonNaucni_CheckedChanged);
            // 
            // radioButtonStrip
            // 
            this.radioButtonStrip.AutoSize = true;
            this.radioButtonStrip.Location = new System.Drawing.Point(18, 53);
            this.radioButtonStrip.Name = "radioButtonStrip";
            this.radioButtonStrip.Size = new System.Drawing.Size(46, 17);
            this.radioButtonStrip.TabIndex = 1;
            this.radioButtonStrip.TabStop = true;
            this.radioButtonStrip.Text = "Strip";
            this.radioButtonStrip.UseVisualStyleBackColor = true;
            this.radioButtonStrip.CheckedChanged += new System.EventHandler(this.radioButtonStrip_CheckedChanged);
            // 
            // radioButtonObicna
            // 
            this.radioButtonObicna.AutoSize = true;
            this.radioButtonObicna.Location = new System.Drawing.Point(18, 19);
            this.radioButtonObicna.Name = "radioButtonObicna";
            this.radioButtonObicna.Size = new System.Drawing.Size(90, 17);
            this.radioButtonObicna.TabIndex = 0;
            this.radioButtonObicna.TabStop = true;
            this.radioButtonObicna.Text = "Obicna knjiga";
            this.radioButtonObicna.UseVisualStyleBackColor = true;
            this.radioButtonObicna.CheckedChanged += new System.EventHandler(this.radioButtonObicna_CheckedChanged);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(304, 366);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(106, 23);
            this.buttonOdustani.TabIndex = 33;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonRegistruj
            // 
            this.buttonRegistruj.Location = new System.Drawing.Point(429, 366);
            this.buttonRegistruj.Name = "buttonRegistruj";
            this.buttonRegistruj.Size = new System.Drawing.Size(106, 23);
            this.buttonRegistruj.TabIndex = 32;
            this.buttonRegistruj.Text = "Registruj";
            this.buttonRegistruj.UseVisualStyleBackColor = true;
            this.buttonRegistruj.Click += new System.EventHandler(this.buttonRegistruj_Click);
            // 
            // labelKuca
            // 
            this.labelKuca.AutoSize = true;
            this.labelKuca.Location = new System.Drawing.Point(301, 125);
            this.labelKuca.Name = "labelKuca";
            this.labelKuca.Size = new System.Drawing.Size(87, 13);
            this.labelKuca.TabIndex = 15;
            this.labelKuca.Text = "Izdavacka kuca:";
            this.labelKuca.Visible = false;
            // 
            // textBoxKuca
            // 
            this.textBoxKuca.Location = new System.Drawing.Point(304, 141);
            this.textBoxKuca.Name = "textBoxKuca";
            this.textBoxKuca.Size = new System.Drawing.Size(168, 20);
            this.textBoxKuca.TabIndex = 16;
            this.textBoxKuca.Visible = false;
            // 
            // labelUmjetnici
            // 
            this.labelUmjetnici.AutoSize = true;
            this.labelUmjetnici.Location = new System.Drawing.Point(302, 204);
            this.labelUmjetnici.Name = "labelUmjetnici";
            this.labelUmjetnici.Size = new System.Drawing.Size(53, 13);
            this.labelUmjetnici.TabIndex = 17;
            this.labelUmjetnici.Text = "Umjetnici:";
            this.labelUmjetnici.Visible = false;
            // 
            // labelIzdanje
            // 
            this.labelIzdanje.AutoSize = true;
            this.labelIzdanje.Location = new System.Drawing.Point(301, 253);
            this.labelIzdanje.Name = "labelIzdanje";
            this.labelIzdanje.Size = new System.Drawing.Size(64, 13);
            this.labelIzdanje.TabIndex = 19;
            this.labelIzdanje.Text = "Broj izdanja:";
            this.labelIzdanje.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(304, 269);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSpecijalno);
            this.groupBox2.Controls.Add(this.radioButtonObicno);
            this.groupBox2.Location = new System.Drawing.Point(304, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 71);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta izdanja";
            this.groupBox2.Visible = false;
            // 
            // radioButtonSpecijalno
            // 
            this.radioButtonSpecijalno.AutoSize = true;
            this.radioButtonSpecijalno.Location = new System.Drawing.Point(6, 40);
            this.radioButtonSpecijalno.Name = "radioButtonSpecijalno";
            this.radioButtonSpecijalno.Size = new System.Drawing.Size(110, 17);
            this.radioButtonSpecijalno.TabIndex = 1;
            this.radioButtonSpecijalno.TabStop = true;
            this.radioButtonSpecijalno.Text = "Specijalno izdanje";
            this.radioButtonSpecijalno.UseVisualStyleBackColor = true;
            // 
            // radioButtonObicno
            // 
            this.radioButtonObicno.AutoSize = true;
            this.radioButtonObicno.Location = new System.Drawing.Point(6, 17);
            this.radioButtonObicno.Name = "radioButtonObicno";
            this.radioButtonObicno.Size = new System.Drawing.Size(95, 17);
            this.radioButtonObicno.TabIndex = 0;
            this.radioButtonObicno.TabStop = true;
            this.radioButtonObicno.Text = "Obicno izdanje";
            this.radioButtonObicno.UseVisualStyleBackColor = true;
            // 
            // labelOblast
            // 
            this.labelOblast.AutoSize = true;
            this.labelOblast.Location = new System.Drawing.Point(302, 125);
            this.labelOblast.Name = "labelOblast";
            this.labelOblast.Size = new System.Drawing.Size(73, 13);
            this.labelOblast.TabIndex = 22;
            this.labelOblast.Text = "Oblast nauke:";
            this.labelOblast.Visible = false;
            // 
            // labelKonferencija
            // 
            this.labelKonferencija.AutoSize = true;
            this.labelKonferencija.Location = new System.Drawing.Point(302, 164);
            this.labelKonferencija.Name = "labelKonferencija";
            this.labelKonferencija.Size = new System.Drawing.Size(69, 13);
            this.labelKonferencija.TabIndex = 23;
            this.labelKonferencija.Text = "Konferencija:";
            this.labelKonferencija.Visible = false;
            // 
            // textBoxKonferencija
            // 
            this.textBoxKonferencija.Location = new System.Drawing.Point(304, 181);
            this.textBoxKonferencija.Name = "textBoxKonferencija";
            this.textBoxKonferencija.Size = new System.Drawing.Size(168, 20);
            this.textBoxKonferencija.TabIndex = 24;
            this.textBoxKonferencija.Visible = false;
            // 
            // listBoxAutori
            // 
            this.listBoxAutori.FormattingEnabled = true;
            this.listBoxAutori.Location = new System.Drawing.Point(18, 132);
            this.listBoxAutori.Name = "listBoxAutori";
            this.listBoxAutori.Size = new System.Drawing.Size(168, 69);
            this.listBoxAutori.TabIndex = 25;
            // 
            // textBoxDodaj
            // 
            this.textBoxDodaj.Location = new System.Drawing.Point(18, 89);
            this.textBoxDodaj.Name = "textBoxDodaj";
            this.textBoxDodaj.Size = new System.Drawing.Size(168, 20);
            this.textBoxDodaj.TabIndex = 3;
            // 
            // labelDodaj
            // 
            this.labelDodaj.AutoSize = true;
            this.labelDodaj.Location = new System.Drawing.Point(15, 73);
            this.labelDodaj.Name = "labelDodaj";
            this.labelDodaj.Size = new System.Drawing.Size(71, 13);
            this.labelDodaj.TabIndex = 27;
            this.labelDodaj.Text = "Dodaj autora:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(192, 84);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(48, 29);
            this.buttonDodaj.TabIndex = 28;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxDodajUmj
            // 
            this.textBoxDodajUmj.Location = new System.Drawing.Point(305, 181);
            this.textBoxDodajUmj.Name = "textBoxDodajUmj";
            this.textBoxDodajUmj.Size = new System.Drawing.Size(168, 20);
            this.textBoxDodajUmj.TabIndex = 29;
            this.textBoxDodajUmj.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(304, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 30);
            this.listBox1.TabIndex = 30;
            this.listBox1.Visible = false;
            // 
            // labelDodajUmj
            // 
            this.labelDodajUmj.AutoSize = true;
            this.labelDodajUmj.Location = new System.Drawing.Point(302, 164);
            this.labelDodajUmj.Name = "labelDodajUmj";
            this.labelDodajUmj.Size = new System.Drawing.Size(86, 13);
            this.labelDodajUmj.TabIndex = 31;
            this.labelDodajUmj.Text = "Dodaj umjetnika:";
            this.labelDodajUmj.Visible = false;
            // 
            // buttonDodajUmj
            // 
            this.buttonDodajUmj.Location = new System.Drawing.Point(478, 176);
            this.buttonDodajUmj.Name = "buttonDodajUmj";
            this.buttonDodajUmj.Size = new System.Drawing.Size(45, 29);
            this.buttonDodajUmj.TabIndex = 32;
            this.buttonDodajUmj.Text = "Dodaj";
            this.buttonDodajUmj.UseVisualStyleBackColor = true;
            this.buttonDodajUmj.Visible = false;
            this.buttonDodajUmj.Click += new System.EventHandler(this.buttonDodajUmj_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Azuriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistracijaKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonDodajUmj);
            this.Controls.Add(this.labelDodajUmj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxDodajUmj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelDodaj);
            this.Controls.Add(this.textBoxDodaj);
            this.Controls.Add(this.listBoxAutori);
            this.Controls.Add(this.textBoxKonferencija);
            this.Controls.Add(this.labelKonferencija);
            this.Controls.Add(this.labelOblast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.labelIzdanje);
            this.Controls.Add(this.labelUmjetnici);
            this.Controls.Add(this.textBoxKuca);
            this.Controls.Add(this.labelKuca);
            this.Controls.Add(this.buttonRegistruj);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.textBoxIzdavac);
            this.Controls.Add(this.labelIzdavac);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelZanr);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAutori);
            this.Controls.Add(this.textBoxNaslov);
            this.Controls.Add(this.labelNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistracijaKnjige";
            this.Text = "RegistracijaKnjige";
            this.Load += new System.EventHandler(this.RegistracijaKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.Label labelAutori;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelZanr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelIzdavac;
        private System.Windows.Forms.TextBox textBoxIzdavac;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNaucni;
        private System.Windows.Forms.RadioButton radioButtonStrip;
        private System.Windows.Forms.RadioButton radioButtonObicna;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonRegistruj;
        private System.Windows.Forms.Label labelKuca;
        private System.Windows.Forms.TextBox textBoxKuca;
        private System.Windows.Forms.Label labelUmjetnici;
        private System.Windows.Forms.Label labelIzdanje;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSpecijalno;
        private System.Windows.Forms.RadioButton radioButtonObicno;
        private System.Windows.Forms.Label labelOblast;
        private System.Windows.Forms.Label labelKonferencija;
        private System.Windows.Forms.TextBox textBoxKonferencija;
        private System.Windows.Forms.ListBox listBoxAutori;
        private System.Windows.Forms.TextBox textBoxDodaj;
        private System.Windows.Forms.Label labelDodaj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxDodajUmj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelDodajUmj;
        private System.Windows.Forms.Button buttonDodajUmj;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}