namespace Bachelory
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.AuthorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnTelebe = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQrup = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.AuthorPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(35, 8);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(25, 25);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 5;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            this.pbHome.MouseHover += new System.EventHandler(this.pbHome_MouseHover);
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.Location = new System.Drawing.Point(624, 9);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(23, 24);
            this.btnMini.TabIndex = 4;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(653, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.AllowDrop = true;
            this.TopPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.TopPanel.Controls.Add(this.pbHome);
            this.TopPanel.Controls.Add(this.btnMini);
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(183, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(687, 42);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bachelor";
            // 
            // HomePanel
            // 
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(183, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(687, 518);
            this.HomePanel.TabIndex = 15;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.leftPanel.Controls.Add(this.lbQrup);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.AuthorPanel);
            this.leftPanel.Controls.Add(this.btnElaveEt);
            this.leftPanel.Controls.Add(this.btnS);
            this.leftPanel.Controls.Add(this.btnR);
            this.leftPanel.Controls.Add(this.btnK);
            this.leftPanel.Controls.Add(this.btnTelebe);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(183, 518);
            this.leftPanel.TabIndex = 12;
            // 
            // AuthorPanel
            // 
            this.AuthorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.AuthorPanel.Controls.Add(this.label2);
            this.AuthorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AuthorPanel.Location = new System.Drawing.Point(0, 480);
            this.AuthorPanel.Name = "AuthorPanel";
            this.AuthorPanel.Size = new System.Drawing.Size(183, 38);
            this.AuthorPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(c) 2016 Rafat Rzayev";
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnElaveEt.FlatAppearance.BorderSize = 0;
            this.btnElaveEt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElaveEt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElaveEt.ForeColor = System.Drawing.Color.LightGray;
            this.btnElaveEt.Location = new System.Drawing.Point(0, 178);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(183, 34);
            this.btnElaveEt.TabIndex = 6;
            this.btnElaveEt.Text = "           Əlavə et";
            this.btnElaveEt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElaveEt.UseVisualStyleBackColor = false;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.Color.LightGray;
            this.btnS.Location = new System.Drawing.Point(0, 144);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(183, 34);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "           Semestr";
            this.btnS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.Color.LightGray;
            this.btnR.Location = new System.Drawing.Point(0, 110);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(183, 34);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "           Referat";
            this.btnR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnK.FlatAppearance.BorderSize = 0;
            this.btnK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.ForeColor = System.Drawing.Color.LightGray;
            this.btnK.Location = new System.Drawing.Point(0, 76);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(183, 34);
            this.btnK.TabIndex = 3;
            this.btnK.Text = "           Kollokvium";
            this.btnK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnTelebe
            // 
            this.btnTelebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTelebe.FlatAppearance.BorderSize = 0;
            this.btnTelebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnTelebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelebe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelebe.ForeColor = System.Drawing.Color.LightGray;
            this.btnTelebe.Location = new System.Drawing.Point(0, 42);
            this.btnTelebe.Name = "btnTelebe";
            this.btnTelebe.Size = new System.Drawing.Size(183, 34);
            this.btnTelebe.TabIndex = 2;
            this.btnTelebe.Text = "           Tələbə";
            this.btnTelebe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelebe.UseVisualStyleBackColor = false;
            this.btnTelebe.Click += new System.EventHandler(this.btnTelebe_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(183, 42);
            this.logoPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qrup";
            // 
            // lbQrup
            // 
            this.lbQrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lbQrup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQrup.ForeColor = System.Drawing.Color.Coral;
            this.lbQrup.FormattingEnabled = true;
            this.lbQrup.ItemHeight = 21;
            this.lbQrup.Location = new System.Drawing.Point(1, 248);
            this.lbQrup.Name = "lbQrup";
            this.lbQrup.Size = new System.Drawing.Size(182, 235);
            this.lbQrup.TabIndex = 9;
            this.lbQrup.SelectedIndexChanged += new System.EventHandler(this.lbQrup_SelectedIndexChanged);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 518);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.AuthorPanel.ResumeLayout(false);
            this.AuthorPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel AuthorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnTelebe;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbQrup;
    }
}