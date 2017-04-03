namespace RPRZadaca2
{
    partial class DataGridUposleni
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(12, 296);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(308, 23);
            this.buttonOdustani.TabIndex = 1;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(331, 296);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(308, 23);
            this.buttonSpremi.TabIndex = 2;
            this.buttonSpremi.Text = "Spremi u bazu";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            // 
            // DataGridKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 342);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridKnjige";
            this.Text = "DataGridKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonSpremi;
    }
}