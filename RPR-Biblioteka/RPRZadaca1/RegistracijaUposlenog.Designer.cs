namespace RPRZadaca1
{
    partial class RegistracijaUposlenog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaUposlenog));
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPotvrda = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPotvrda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxJMBG = new System.Windows.Forms.RichTextBox();
            this.ubacivanjeSlike1 = new RPRZadaca1.UbacivanjeSlike();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(26, 34);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(200, 20);
            this.textBoxIme.TabIndex = 0;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            this.textBoxIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIme_Validating);
            this.textBoxIme.Validated += new System.EventHandler(this.textBoxIme_Validated);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(26, 82);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrezime.TabIndex = 1;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxPrezime_TextChanged);
            this.textBoxPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezime_Validating);
            this.textBoxPrezime.Validated += new System.EventHandler(this.textBoxPrezime_Validated);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(26, 236);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            this.textBoxUsername.Validated += new System.EventHandler(this.textBoxUsername_Validated);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(26, 275);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // textBoxPotvrda
            // 
            this.textBoxPotvrda.Location = new System.Drawing.Point(26, 314);
            this.textBoxPotvrda.Name = "textBoxPotvrda";
            this.textBoxPotvrda.PasswordChar = '*';
            this.textBoxPotvrda.Size = new System.Drawing.Size(200, 20);
            this.textBoxPotvrda.TabIndex = 5;
            this.textBoxPotvrda.TextChanged += new System.EventHandler(this.textBoxPotvrda_TextChanged);
            this.textBoxPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPotvrda_Validating);
            this.textBoxPotvrda.Validated += new System.EventHandler(this.textBoxPotvrda_Validated);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(23, 18);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 6;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(23, 66);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 7;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Location = new System.Drawing.Point(23, 181);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(39, 13);
            this.labelJMBG.TabIndex = 8;
            this.labelJMBG.Text = "JMBG:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(23, 119);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(80, 13);
            this.labelDatum.TabIndex = 9;
            this.labelDatum.Text = "Datum rođenja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(23, 220);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(23, 259);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password:";
            // 
            // labelPotvrda
            // 
            this.labelPotvrda.AutoSize = true;
            this.labelPotvrda.Location = new System.Drawing.Point(23, 298);
            this.labelPotvrda.Name = "labelPotvrda";
            this.labelPotvrda.Size = new System.Drawing.Size(91, 13);
            this.labelPotvrda.TabIndex = 13;
            this.labelPotvrda.Text = "Potvrdi password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Registruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(26, 198);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(200, 19);
            this.textBoxJMBG.TabIndex = 19;
            this.textBoxJMBG.Text = "";
            this.textBoxJMBG.TextChanged += new System.EventHandler(this.textBoxJMBG_TextChanged);
            this.textBoxJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxJMBG_Validating_1);
            this.textBoxJMBG.Validated += new System.EventHandler(this.textBoxJMBG_Validated);
            // 
            // ubacivanjeSlike1
            // 
            this.ubacivanjeSlike1.Location = new System.Drawing.Point(328, 34);
            this.ubacivanjeSlike1.Name = "ubacivanjeSlike1";
            this.ubacivanjeSlike1.Size = new System.Drawing.Size(139, 169);
            this.ubacivanjeSlike1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Azuriraj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistracijaUposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ubacivanjeSlike1);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPotvrda);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.textBoxPotvrda);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistracijaUposlenog";
            this.Text = "RegistracijaUposlenog";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPotvrda;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPotvrda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox textBoxJMBG;
        private UbacivanjeSlike ubacivanjeSlike1;
        private System.Windows.Forms.Button button3;
    }
}