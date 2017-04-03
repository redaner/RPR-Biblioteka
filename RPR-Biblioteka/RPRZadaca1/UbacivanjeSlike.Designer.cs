namespace RPRZadaca1
{
    partial class UbacivanjeSlike
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(132, 108);
            this.pictureBoxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlika.TabIndex = 0;
            this.pictureBoxSlika.TabStop = false;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(3, 117);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(132, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj sliku";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UbacivanjeSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.pictureBoxSlika);
            this.Name = "UbacivanjeSlike";
            this.Size = new System.Drawing.Size(139, 169);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
