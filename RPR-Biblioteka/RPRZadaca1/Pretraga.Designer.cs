namespace RPRZadaca1
{
    partial class Pretraga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pretraga));
            this.textBoxKnjige = new System.Windows.Forms.TextBox();
            this.textBoxClanovi = new System.Windows.Forms.TextBox();
            this.textBoxUposleni = new System.Windows.Forms.TextBox();
            this.listBoxKnjige = new System.Windows.Forms.ListBox();
            this.listBoxClanovi = new System.Windows.Forms.ListBox();
            this.listBoxUposleni = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKnjige
            // 
            this.textBoxKnjige.Location = new System.Drawing.Point(30, 78);
            this.textBoxKnjige.Name = "textBoxKnjige";
            this.textBoxKnjige.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnjige.TabIndex = 0;
            this.textBoxKnjige.TextChanged += new System.EventHandler(this.textBoxKnjige_TextChanged);
            // 
            // textBoxClanovi
            // 
            this.textBoxClanovi.Location = new System.Drawing.Point(190, 78);
            this.textBoxClanovi.Name = "textBoxClanovi";
            this.textBoxClanovi.Size = new System.Drawing.Size(100, 20);
            this.textBoxClanovi.TabIndex = 1;
            this.textBoxClanovi.TextChanged += new System.EventHandler(this.textBoxClanovi_TextChanged);
            // 
            // textBoxUposleni
            // 
            this.textBoxUposleni.Location = new System.Drawing.Point(347, 78);
            this.textBoxUposleni.Name = "textBoxUposleni";
            this.textBoxUposleni.Size = new System.Drawing.Size(100, 20);
            this.textBoxUposleni.TabIndex = 2;
            this.textBoxUposleni.TextChanged += new System.EventHandler(this.textBoxUposleni_TextChanged);
            // 
            // listBoxKnjige
            // 
            this.listBoxKnjige.FormattingEnabled = true;
            this.listBoxKnjige.Location = new System.Drawing.Point(30, 112);
            this.listBoxKnjige.Name = "listBoxKnjige";
            this.listBoxKnjige.Size = new System.Drawing.Size(100, 160);
            this.listBoxKnjige.TabIndex = 3;
            // 
            // listBoxClanovi
            // 
            this.listBoxClanovi.FormattingEnabled = true;
            this.listBoxClanovi.Location = new System.Drawing.Point(190, 112);
            this.listBoxClanovi.Name = "listBoxClanovi";
            this.listBoxClanovi.Size = new System.Drawing.Size(100, 160);
            this.listBoxClanovi.TabIndex = 4;
            // 
            // listBoxUposleni
            // 
            this.listBoxUposleni.FormattingEnabled = true;
            this.listBoxUposleni.Location = new System.Drawing.Point(347, 112);
            this.listBoxUposleni.Name = "listBoxUposleni";
            this.listBoxUposleni.Size = new System.Drawing.Size(100, 160);
            this.listBoxUposleni.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraga knjiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraga clanova:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pretraga uposlenih:";
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUposleni);
            this.Controls.Add(this.listBoxClanovi);
            this.Controls.Add(this.listBoxKnjige);
            this.Controls.Add(this.textBoxUposleni);
            this.Controls.Add(this.textBoxClanovi);
            this.Controls.Add(this.textBoxKnjige);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKnjige;
        private System.Windows.Forms.TextBox textBoxClanovi;
        private System.Windows.Forms.TextBox textBoxUposleni;
        private System.Windows.Forms.ListBox listBoxKnjige;
        private System.Windows.Forms.ListBox listBoxClanovi;
        private System.Windows.Forms.ListBox listBoxUposleni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}