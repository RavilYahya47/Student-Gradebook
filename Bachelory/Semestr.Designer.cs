namespace Bachelory
{
    partial class Semestr
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
            this.lblAd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHesabla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSiyahi = new System.Windows.Forms.ListBox();
            this.cmbQrup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Red;
            this.lblAd.Location = new System.Drawing.Point(301, 404);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(369, 31);
            this.lblAd.TabIndex = 24;
            this.lblAd.Text = "....";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(473, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 24);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHesabla
            // 
            this.btnHesabla.BackColor = System.Drawing.Color.Red;
            this.btnHesabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesabla.ForeColor = System.Drawing.Color.White;
            this.btnHesabla.Location = new System.Drawing.Point(371, 438);
            this.btnHesabla.Name = "btnHesabla";
            this.btnHesabla.Size = new System.Drawing.Size(96, 24);
            this.btnHesabla.TabIndex = 22;
            this.btnHesabla.Text = "Hesabla";
            this.btnHesabla.UseVisualStyleBackColor = false;
            this.btnHesabla.Click += new System.EventHandler(this.btnHesabla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(301, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 390);
            this.panel1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(120, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 26);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sual sayı:";
            // 
            // lbSiyahi
            // 
            this.lbSiyahi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiyahi.FormattingEnabled = true;
            this.lbSiyahi.ItemHeight = 16;
            this.lbSiyahi.Location = new System.Drawing.Point(13, 83);
            this.lbSiyahi.Name = "lbSiyahi";
            this.lbSiyahi.Size = new System.Drawing.Size(275, 372);
            this.lbSiyahi.TabIndex = 18;
            this.lbSiyahi.SelectedIndexChanged += new System.EventHandler(this.lbSiyahi_SelectedIndexChanged);
            // 
            // cmbQrup
            // 
            this.cmbQrup.BackColor = System.Drawing.Color.DarkGreen;
            this.cmbQrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQrup.FormattingEnabled = true;
            this.cmbQrup.Location = new System.Drawing.Point(120, 12);
            this.cmbQrup.Name = "cmbQrup";
            this.cmbQrup.Size = new System.Drawing.Size(168, 28);
            this.cmbQrup.TabIndex = 17;
            this.cmbQrup.SelectedIndexChanged += new System.EventHandler(this.cmbQrup_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Qrup:";
            // 
            // Semestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 472);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHesabla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSiyahi);
            this.Controls.Add(this.cmbQrup);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Semestr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semestr";
            this.Load += new System.EventHandler(this.Semestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHesabla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSiyahi;
        private System.Windows.Forms.ComboBox cmbQrup;
        private System.Windows.Forms.Label label2;
    }
}