namespace RPRZadaca1
{
    partial class RegistracijaClana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaClana));
            this.labelIme = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMjesecno = new System.Windows.Forms.RadioButton();
            this.radioButtonGodisnje = new System.Windows.Forms.RadioButton();
            this.labelMetoda = new System.Windows.Forms.Label();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonObicni = new System.Windows.Forms.RadioButton();
            this.radioButtonProfesor = new System.Windows.Forms.RadioButton();
            this.radioButtonMaster = new System.Windows.Forms.RadioButton();
            this.groupBoxVrsta = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRegistruj = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelSifra = new System.Windows.Forms.Label();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPotvrda = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPotvrda = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxJMBG = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ubacivanjeSlike1 = new RPRZadaca1.UbacivanjeSlike();
            this.groupBoxVrsta.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(21, 9);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(24, 25);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(200, 20);
            this.textBoxIme.TabIndex = 1;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            this.textBoxIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIme_Validating);
            this.textBoxIme.Validated += new System.EventHandler(this.textBoxIme_Validated);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(21, 48);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(24, 64);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrezime.TabIndex = 3;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxPrezime_TextChanged);
            this.textBoxPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezime_Validating);
            this.textBoxPrezime.Validated += new System.EventHandler(this.textBoxPrezime_Validated);
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Location = new System.Drawing.Point(21, 138);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(39, 13);
            this.labelJMBG.TabIndex = 4;
            this.labelJMBG.Text = "JMBG:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(21, 87);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(80, 13);
            this.labelDatum.TabIndex = 6;
            this.labelDatum.Text = "Datum rođenja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // radioButtonMjesecno
            // 
            this.radioButtonMjesecno.AutoSize = true;
            this.radioButtonMjesecno.Location = new System.Drawing.Point(24, 203);
            this.radioButtonMjesecno.Name = "radioButtonMjesecno";
            this.radioButtonMjesecno.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMjesecno.TabIndex = 8;
            this.radioButtonMjesecno.TabStop = true;
            this.radioButtonMjesecno.Text = "Mjesečno";
            this.radioButtonMjesecno.UseVisualStyleBackColor = true;
            // 
            // radioButtonGodisnje
            // 
            this.radioButtonGodisnje.AutoSize = true;
            this.radioButtonGodisnje.Location = new System.Drawing.Point(139, 203);
            this.radioButtonGodisnje.Name = "radioButtonGodisnje";
            this.radioButtonGodisnje.Size = new System.Drawing.Size(66, 17);
            this.radioButtonGodisnje.TabIndex = 9;
            this.radioButtonGodisnje.TabStop = true;
            this.radioButtonGodisnje.Text = "Godišnje";
            this.radioButtonGodisnje.UseVisualStyleBackColor = true;
            // 
            // labelMetoda
            // 
            this.labelMetoda.AutoSize = true;
            this.labelMetoda.Location = new System.Drawing.Point(21, 187);
            this.labelMetoda.Name = "labelMetoda";
            this.labelMetoda.Size = new System.Drawing.Size(89, 13);
            this.labelMetoda.TabIndex = 10;
            this.labelMetoda.Text = "Metoda plaćanja:";
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(117, 19);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonStudent.TabIndex = 12;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // radioButtonObicni
            // 
            this.radioButtonObicni.AutoSize = true;
            this.radioButtonObicni.Location = new System.Drawing.Point(6, 19);
            this.radioButtonObicni.Name = "radioButtonObicni";
            this.radioButtonObicni.Size = new System.Drawing.Size(55, 17);
            this.radioButtonObicni.TabIndex = 11;
            this.radioButtonObicni.TabStop = true;
            this.radioButtonObicni.Text = "Obični";
            this.radioButtonObicni.UseVisualStyleBackColor = true;
            this.radioButtonObicni.CheckedChanged += new System.EventHandler(this.radioButtonObicni_CheckedChanged);
            // 
            // radioButtonProfesor
            // 
            this.radioButtonProfesor.AutoSize = true;
            this.radioButtonProfesor.Location = new System.Drawing.Point(117, 63);
            this.radioButtonProfesor.Name = "radioButtonProfesor";
            this.radioButtonProfesor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProfesor.TabIndex = 14;
            this.radioButtonProfesor.TabStop = true;
            this.radioButtonProfesor.Text = "Profesor";
            this.radioButtonProfesor.UseVisualStyleBackColor = true;
            this.radioButtonProfesor.CheckedChanged += new System.EventHandler(this.radioButtonProfesor_CheckedChanged);
            // 
            // radioButtonMaster
            // 
            this.radioButtonMaster.AutoSize = true;
            this.radioButtonMaster.Location = new System.Drawing.Point(6, 63);
            this.radioButtonMaster.Name = "radioButtonMaster";
            this.radioButtonMaster.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMaster.TabIndex = 13;
            this.radioButtonMaster.TabStop = true;
            this.radioButtonMaster.Text = "Master student";
            this.radioButtonMaster.UseVisualStyleBackColor = true;
            this.radioButtonMaster.CheckedChanged += new System.EventHandler(this.radioButtonMaster_CheckedChanged);
            // 
            // groupBoxVrsta
            // 
            this.groupBoxVrsta.Controls.Add(this.radioButtonObicni);
            this.groupBoxVrsta.Controls.Add(this.radioButtonProfesor);
            this.groupBoxVrsta.Controls.Add(this.radioButtonMaster);
            this.groupBoxVrsta.Controls.Add(this.radioButtonStudent);
            this.groupBoxVrsta.Location = new System.Drawing.Point(24, 226);
            this.groupBoxVrsta.Name = "groupBoxVrsta";
            this.groupBoxVrsta.Size = new System.Drawing.Size(200, 95);
            this.groupBoxVrsta.TabIndex = 10;
            this.groupBoxVrsta.TabStop = false;
            this.groupBoxVrsta.Text = "Vrsta člana";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRegistruj
            // 
            this.buttonRegistruj.Location = new System.Drawing.Point(371, 342);
            this.buttonRegistruj.Name = "buttonRegistruj";
            this.buttonRegistruj.Size = new System.Drawing.Size(99, 23);
            this.buttonRegistruj.TabIndex = 29;
            this.buttonRegistruj.Text = "Registruj";
            this.buttonRegistruj.UseVisualStyleBackColor = true;
            this.buttonRegistruj.Click += new System.EventHandler(this.buttonRegistruj_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(24, 329);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(68, 13);
            this.labelIndex.TabIndex = 20;
            this.labelIndex.Text = "Broj indeksa:";
            this.labelIndex.Visible = false;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(27, 345);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(197, 20);
            this.textBoxIndex.TabIndex = 16;
            this.textBoxIndex.Visible = false;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            this.textBoxIndex.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIndex_Validating);
            this.textBoxIndex.Validated += new System.EventHandler(this.textBoxIndex_Validated);
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(24, 329);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(88, 13);
            this.labelSifra.TabIndex = 22;
            this.labelSifra.Text = "Sifra zaposlenog:";
            this.labelSifra.Visible = false;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(265, 342);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(100, 23);
            this.buttonOdustani.TabIndex = 28;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(346, 226);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(138, 20);
            this.textBoxUsername.TabIndex = 24;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            this.textBoxUsername.Validated += new System.EventHandler(this.textBoxUsername_Validated);
            // 
            // textBoxPotvrda
            // 
            this.textBoxPotvrda.Location = new System.Drawing.Point(346, 301);
            this.textBoxPotvrda.Name = "textBoxPotvrda";
            this.textBoxPotvrda.PasswordChar = '*';
            this.textBoxPotvrda.Size = new System.Drawing.Size(138, 20);
            this.textBoxPotvrda.TabIndex = 27;
            this.textBoxPotvrda.TextChanged += new System.EventHandler(this.textBoxPotvrda_TextChanged);
            this.textBoxPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPotvrda_Validating);
            this.textBoxPotvrda.Validated += new System.EventHandler(this.textBoxPotvrda_Validated);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(346, 262);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(138, 20);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // labelPotvrda
            // 
            this.labelPotvrda.AutoSize = true;
            this.labelPotvrda.Location = new System.Drawing.Point(238, 304);
            this.labelPotvrda.Name = "labelPotvrda";
            this.labelPotvrda.Size = new System.Drawing.Size(100, 13);
            this.labelPotvrda.TabIndex = 27;
            this.labelPotvrda.Text = "Potvrdite password:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(282, 265);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(282, 229);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 29;
            this.labelUsername.Text = "Username:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(24, 155);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(200, 20);
            this.textBoxJMBG.TabIndex = 7;
            this.textBoxJMBG.Text = "";
            this.textBoxJMBG.TextChanged += new System.EventHandler(this.textBoxJMBG_TextChanged);
            this.textBoxJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxJMBG_Validating_1);
            this.textBoxJMBG.Validated += new System.EventHandler(this.textBoxJMBG_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Azuriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ubacivanjeSlike1
            // 
            this.ubacivanjeSlike1.Location = new System.Drawing.Point(346, 25);
            this.ubacivanjeSlike1.Name = "ubacivanjeSlike1";
            this.ubacivanjeSlike1.Size = new System.Drawing.Size(139, 169);
            this.ubacivanjeSlike1.TabIndex = 31;
            // 
            // RegistracijaClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ubacivanjeSlike1);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPotvrda);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPotvrda);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.buttonRegistruj);
            this.Controls.Add(this.groupBoxVrsta);
            this.Controls.Add(this.labelMetoda);
            this.Controls.Add(this.radioButtonGodisnje);
            this.Controls.Add(this.radioButtonMjesecno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistracijaClana";
            this.Text = "Registracija Clana";
            this.groupBoxVrsta.ResumeLayout(false);
            this.groupBoxVrsta.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonMjesecno;
        private System.Windows.Forms.RadioButton radioButtonGodisnje;
        private System.Windows.Forms.Label labelMetoda;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonObicni;
        private System.Windows.Forms.RadioButton radioButtonProfesor;
        private System.Windows.Forms.RadioButton radioButtonMaster;
        private System.Windows.Forms.GroupBox groupBoxVrsta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRegistruj;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPotvrda;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPotvrda;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox textBoxJMBG;
        private UbacivanjeSlike ubacivanjeSlike1;
        private System.Windows.Forms.Button button1;
    }
}